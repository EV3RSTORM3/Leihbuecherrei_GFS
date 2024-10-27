using System;
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
            if (!borrowEntry.Returned)
            {
                //disables and showes nothing in the DateTimePicker when returned is false which means ReturnedOn is null
                DtpReturnedOn.Enabled = false;
                DtpReturnedOn.Format = DateTimePickerFormat.Custom;
                DtpReturnedOn.CustomFormat = " ";
            }
            else
            {
                //?? handles the possibility of ReturnedOn being null
                DtpReturnedOn.Value = borrowEntry.ReturnedOn?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Now;
            }

            CbClosed.Checked = borrowEntry.Closed;

            BtnSave.Enabled = false;
            BtnSaveAndClose.Enabled = false;
        }

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;

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

        private void TxtSearchReader_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);
            }
        }

        private void TxtSearchBook_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text, true);
            }
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.DisplayBorrowEntryBtnDeleteClick(borrowEntry);
                this.Close();
            }
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            if (control.DisplayBorrowEntryBtnSaveClick(borrowEntry, LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book, DateOnly.FromDateTime(DtpBorrowedOn.Value), DateOnly.FromDateTime(DtpDueTo.Value), CbReturned.Checked, DateOnly.FromDateTime(DtpReturnedOn.Value), CbClosed.Checked) == false)
            {
                MessageBox.Show("Borrowed On can not be set to the future");
            }
        }

        private void BtnSaveAndClose_Click( object sender, EventArgs e )
        {
            if (control.DisplayBorrowEntryBtnSaveClick(borrowEntry, LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book, DateOnly.FromDateTime(DtpBorrowedOn.Value), DateOnly.FromDateTime(DtpDueTo.Value), CbReturned.Checked, DateOnly.FromDateTime(DtpReturnedOn.Value), CbClosed.Checked) == false)
            {
                MessageBox.Show("Borrowed On can not be set to the future");
            }
            else
            {
                this.Close();
            }
        }

        private void BtnClose_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
