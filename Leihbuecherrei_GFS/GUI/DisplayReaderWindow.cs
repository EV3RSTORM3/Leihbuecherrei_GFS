using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leihbuecherrei_GFS.GUI
{
    public partial class DisplayReaderWindow : Form
    {
        private Control control;
        private Reader reader;

        public DisplayReaderWindow( Control pControl, Reader pReader )
        {
            control = pControl;
            reader = pReader;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //sets the title of the window to the name of the reader
            this.Text = reader.Name;

            TxtName.Text = reader.Name;
            TxtId.Text = Convert.ToString(reader.Id);
            TxtCity.Text = reader.City;
            TxtAddress.Text = reader.Address;

            //?? handles the possibility of Birthday being null
            //Have to Add a TimeOnly to the DateOnly to make a DateTime, because WinForms DateTimepicker only accepts DateTime variables
            DtpBirthday.Value = reader.Birthday?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Today;

            if (reader.Birthday == null)
            {
                DtpBirthday.Format = DateTimePickerFormat.Custom;
                DtpBirthday.CustomFormat = " ";
            }

            //Initializes the list of reservations
            LbReservations.DataSource = control.GetWaitinglist(reader);

            //Initializes the list of borrow entries
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(Convert.ToString(reader.Id), string.Empty, CheckState.Indeterminate, CheckState.Indeterminate);

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnApply.Enabled = false;
            BtnOk.Enabled = false;
        }

        //if the user enters the DateTimePicker, the DateTimePicker will show the date
        private void DtpBirthday_Enter( object sender, EventArgs e )
        {
            DtpBirthday.Format = DateTimePickerFormat.Short;
        }

        //if the user leaves the DateTimePicker without selecting a date, the DateTimePicker will show nothing
        private void DtpBirthday_Leave( object sender, EventArgs e )
        {
            if (DateOnly.FromDateTime(DtpBirthday.Value).CompareTo(DateOnly.FromDateTime(DateTime.Today)) >= 0)
            {
                DtpBirthday.Format = DateTimePickerFormat.Custom;
                DtpBirthday.CustomFormat = " ";
            }
        }

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged( object sender, EventArgs e )
        {
            BtnApply.Enabled = true;
            BtnOk.Enabled = true;
        }

        //saves the changes to the database without closing the window
        private void BtnApply_Click( object sender, EventArgs e )
        {
            if (control.DisplayReaderSave(reader, TxtName.Text, TxtAddress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                //refreshes the title of the window after save
                this.Text = TxtName.Text;
            }
        }

        //closes the window without saving the changes
        private void BtnCancel_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //saves the changes to the database and closes the window
        private void BtnOk_Click( object sender, EventArgs e )
        {
            if (control.DisplayReaderSave(reader, TxtName.Text, TxtAddress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                this.Close();
            }
        }

        //deletes the reader from the database
        private void BtnDelete_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.DisplayReaderDelete(reader);
                this.Close();
            }
        }

        //opens the AddToWaitingListWindow to add the displayed reader to the waiting list of a book
        private void BtnAddToReservationList_Click( object sender, EventArgs e )
        {
            AddToWaitingListWindow addToWaitingListWindow = new AddToWaitingListWindow(reader, control);
            addToWaitingListWindow.ShowDialog();
            RefreshReservationsList();
        }

        //deletes the selected book from the readers waiting list
        private void BtnDeleteFromReservationList_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remonve the selected book from the users waitinglist?", "Delete Reservation", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.RemoveFromWaitinglist(LbReservations.SelectedItem as Reservation);
            }

            //focuses the OK button when the user leaves the control using tab as the focus would not be transfered if using the tab button normally probably due to the cahnging of the format
            this.BtnOk.Focus();
        }

        private void RefreshReservationsList()
        {
            LbReservations.DataSource = control.GetWaitinglist(reader);
        }

        //opens AddBorrowEntryWindow to add a new BorrowEntry for the displayed reader
        private void BtnNewBorrowEntry_Click( object sender, EventArgs e )
        {
            AddBorrowEntryWindow addBorrowEntryWindow = new AddBorrowEntryWindow(reader, control);

            addBorrowEntryWindow.Location = new Point(0, 0);
            addBorrowEntryWindow.ShowDialog();
        }

        //starts the search if the user hits the search button
        private void BtnBorrowEntrySearch_Click( object sender, EventArgs e )
        {
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(Convert.ToString(reader.Id), TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        //resets the filters for the BorrowEntry search and shows all entries
        private void BtnReset_Click( object sender, EventArgs e )
        {
            TxtSearchBorrowEntryBook.Text = string.Empty;

            //Indeterminate is the default state in which the filter is ignored
            CbClosed.CheckState = CheckState.Indeterminate;
            CbReturned.CheckState = CheckState.Indeterminate;

            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(Convert.ToString(reader.Id), TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        //opens the selected BorrowEntry in a new window
        private void DgvBorrowEntries_DoubleClick( object sender, EventArgs e )
        {
            //Gets the selected BorrowEntry
            BorrowEntry selectedBorrowEntry = DgvBorrowEntries.SelectedRows[0].DataBoundItem as BorrowEntry;

            control.DisplayBorrowEntry(selectedBorrowEntry);
        }
    }
}
