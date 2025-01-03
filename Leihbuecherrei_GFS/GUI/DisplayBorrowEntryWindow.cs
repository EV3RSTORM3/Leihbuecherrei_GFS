﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leihbuecherrei_GFS.GUI
{
    public partial class DisplayBorrowEntryWindow : Form
    {
        private Control control;
        private BorrowEntry borrowEntry;

        public DisplayBorrowEntryWindow( Control pControl, BorrowEntry pBorrowEntry )
        {
            control = pControl;
            borrowEntry = pBorrowEntry;
            InitializeComponent();
            Inizialize();
        }

        private void Inizialize()
        {
            //sets the title of the window to the id of the borrow entry
            this.Text = "Borrow Entry No." + borrowEntry.Id;

            TxtId.Text = Convert.ToString(borrowEntry.Id);

            LbBooks.DataSource = control.SearchBook(Convert.ToString(borrowEntry.Book.Id));
            LbReaders.DataSource = control.SearchReader(Convert.ToString(borrowEntry.Reader.Id));

            DtpBorrowedOn.Value = borrowEntry.BorrowedOn.ToDateTime(new TimeOnly(0, 0));

            DtpDueTo.Value = borrowEntry.DueTo.ToDateTime(new TimeOnly(0, 0));


            CbReturned.Checked = borrowEntry.Returned;

            //note that customformat can not be set before Value is set as Value.set will use custom format even if forma is not set to custom
            //?? handles the possibility of ReturnedOn being null
            DtpReturnedOn.Value = borrowEntry.ReturnedOn?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Today;
            if (borrowEntry.ReturnedOn == null)
            {
                //disables and showes nothing in the DateTimePicker when ReturnedOn is null
                DtpReturnedOn.Enabled = false;
                DtpReturnedOn.Format = DateTimePickerFormat.Custom;
                DtpReturnedOn.CustomFormat = " ";
            }

            CbClosed.Checked = borrowEntry.Closed;

            BtnApply.Enabled = false;
            BtnOk.Enabled = false;
        }

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged( object sender, EventArgs e )
        {
            BtnApply.Enabled = true;
            BtnOk.Enabled = true;
        }
        
        //handels the format and enabled state of the DateTimePicker for the returned on date
        private void CbReturned_CheckedChanged( object sender, EventArgs e )
        {
            BtnApply.Enabled = true;
            BtnOk.Enabled = true;

            if (CbReturned.Checked)
            {
                DtpReturnedOn.Enabled = true;
                DtpReturnedOn.Format = DateTimePickerFormat.Short;
            }
            else
            {
                DtpReturnedOn.Enabled = false;
                DtpReturnedOn.Format = DateTimePickerFormat.Custom;
                DtpReturnedOn.CustomFormat = " ";
            }
        }

        //starts the search if the user hits enter
        private void TxtSearchReader_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);
            }
        }

        //starts the search if the user hits enter
        private void TxtSearchBook_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text, true);
            }
        }

        //deletes the BorrowEntry
        private void BtnDelete_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.DisplayBorrowEntryDelete(borrowEntry);
                this.Close();
            }
        }

        //saves the changes to the database without closing the window
        private void BtnApply_Click( object sender, EventArgs e )
        {
            if (control.DisplayBorrowEntrySave(borrowEntry, LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book, DateOnly.FromDateTime(DtpBorrowedOn.Value), DateOnly.FromDateTime(DtpDueTo.Value), CbReturned.Checked, DateOnly.FromDateTime(DtpReturnedOn.Value), CbClosed.Checked) == false)
            {
                MessageBox.Show("Borrowed On can not be set to the future");
            }
        }

        //saves the changes to the database and closes the window
        private void BtnOk_Click( object sender, EventArgs e )
        {
            if (control.DisplayBorrowEntrySave(borrowEntry, LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book, DateOnly.FromDateTime(DtpBorrowedOn.Value), DateOnly.FromDateTime(DtpDueTo.Value), CbReturned.Checked, DateOnly.FromDateTime(DtpReturnedOn.Value), CbClosed.Checked) == false)
            {
                MessageBox.Show("Borrowed On can not be set to the future");
            }
            else
            {
                this.Close();
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
    }
}
