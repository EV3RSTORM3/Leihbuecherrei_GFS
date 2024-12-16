using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS.GUI
{
    public partial class DisplayBookWindow : Form
    {
        private Control control;
        private Book book;

        public DisplayBookWindow( Control pControl, Book pBook )
        {
            control = pControl;
            book = pBook;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //sets the title of the window to the title of the book
            this.Text = book.Title;

            TxtTitle.Text = book.Title;
            TxtId.Text = Convert.ToString(book.Id);
            TxtPublisher.Text = book.Publisher;
            TxtAuthor.Text = book.Author;

            //Initializes the list of reservations
            LbReservations.DataSource = control.GetWaitinglist(book);

            //Initializes the list of borrow entries
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(string.Empty, Convert.ToString(book.Id), CheckState.Indeterminate, CheckState.Indeterminate);

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnApply.Enabled = false;
            BtnOk.Enabled = false;
        }

        //activates the save buttons when the content of the window is changed
        private void ContentChanged( object sender, EventArgs e )
        {
            BtnApply.Enabled = true;
            BtnOk.Enabled = true;
        }

        private void BtnCancel_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //saves the changes to the database without closing the window
        private void BtnApply_Click( object sender, EventArgs e )
        {
            if (control.DisplayBookSave(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                //refreshes the title of the window after save
                this.Text = TxtTitle.Text;
            }
        }

        //saves the changes to the database and closes the window
        private void BtnOk_Click( object sender, EventArgs e )
        {
            if (control.DisplayBookSave(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                this.Close();
            }
        }

        //deletes the book from the database
        private void BtnDelete_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.DisplayBookDelete(book);
                this.Close();
            }
        }

        //opens the AddToWaitingListWindow to add a reader to the waiting list of the displayed book
        private void BtnAddToReservationList_Click( object sender, EventArgs e )
        {
            AddToWaitingListWindow addToWaitingListWindow = new AddToWaitingListWindow(book, control);
            addToWaitingListWindow.ShowDialog();
            RefreshReservationsList();
        }

        //removes the selected reader from the waiting list of the displayed book
        private void BtnDeleteFromReservationList_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove the selected reader from the books waitinglist?", "Delete Reservation", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.RemoveFromWaitinglist(LbReservations.SelectedItem as Reservation);
            }
        }

        private void RefreshReservationsList()
        {
            LbReservations.DataSource = control.GetWaitinglist(book);
        }

        //opens AddBorrowEntryWindow to add a new borrow entry for the displayed book
        private void BtnNewBorrowEntry_Click( object sender, EventArgs e )
        {
            AddBorrowEntryWindow addBorrowEntryWindow = new AddBorrowEntryWindow(book, control);

            addBorrowEntryWindow.Location = new Point(0, 0);
            addBorrowEntryWindow.ShowDialog();
        }

        //starts the search if the user hits the search button
        private void BtnBorrowEntrySearch_Click( object sender, EventArgs e )
        {
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(TxtSearchBorrowEntryReader.Text, Convert.ToString(book.Id), CbClosed.CheckState, CbReturned.CheckState);
        }

        //resets the filters for the BorrowEntry search and shows all entries
        private void BtnReset_Click( object sender, EventArgs e )
        {
            TxtSearchBorrowEntryReader.Text = string.Empty;

            //Indeterminate is the default state in which the filter is ignored
            CbClosed.CheckState = CheckState.Indeterminate;
            CbReturned.CheckState = CheckState.Indeterminate;

            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(TxtSearchBorrowEntryReader.Text, Convert.ToString(book.Id), CbClosed.CheckState, CbReturned.CheckState);
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
