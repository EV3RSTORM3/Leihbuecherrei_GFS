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
    public partial class AddBorrowEntryWindow : Form
    {
        private Control control;
        public AddBorrowEntryWindow( Control pControl )
        {
            control = pControl;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            LbReaders.DataSource = control.SearchReader("");
            LbReaders.DisplayMember = "IdAndName";

            LbBooks.DataSource = control.AddBorrowEntrySearchBook("");
            LbBooks.DisplayMember = "IdAndTitle";
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
                LbBooks.DataSource = control.AddBorrowEntrySearchBook(TxtSearchBook.Text);
            }
        }

        private void BtnAddEntry_Click( object sender, EventArgs e )
        {
            //check if the date is set to a date after today to ensure all information is given by the user
            //(checking if an item is selected is the LB is unnessecary as there is always one selected)
            int dateComparision = DateOnly.FromDateTime(DtpDueTo.Value).CompareTo(DateOnly.FromDateTime(DateTime.Today));
            if (dateComparision <= 0) 
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else 
            {
                control.AddBorrowEntryBtnSaveClick(LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book, DateOnly.FromDateTime(DtpDueTo.Value));
                Close();
            }
        }
    }
}
