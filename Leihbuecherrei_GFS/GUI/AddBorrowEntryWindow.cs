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
        public AddBorrowEntryWindow(Control pControl)
        {
            control = pControl;
            InitializeComponent();
            Initialize();
        }

        //initializes the listboxes with all readers and books
        private void Initialize()
        {
            LbReaders.DataSource = control.SearchReader(string.Empty);

            LbBooks.DataSource = control.SearchBook(string.Empty);
        }

        //will be used if the user adds a BorrowEntry from the DisplayReaderWindow
        public AddBorrowEntryWindow(Reader pReader, Control pControl)
        {
            control = pControl;
            InitializeComponent();

            LbReaders.Items.Add(pReader);
            LbReaders.SelectedIndex = 0;

            LbBooks.DataSource = control.SearchBook(string.Empty);
        }

        //will be used if the user adds a BorrowEntry from the DisplayBookWindow
        public AddBorrowEntryWindow( Book pBook, Control pControl )
        {
            control = pControl;
            InitializeComponent();

            LbBooks.Items.Add(pBook);
            LbBooks.SelectedIndex = 0;

            LbReaders.DataSource = control.SearchReader(string.Empty);
        }

        //starts the search if the user hits enter
        private void TxtSearchReader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);

                //focuses LbReaders after the user hits enter to search
                this.LbReaders.Focus();
            }
        }

        //starts the search if the user hits enter
        private void TxtSearchBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text);

                //focuses LbBooks after the user hits enter to search
                this.LbBooks.Focus();
            }
        }

        //adds the BorrowEntry or asks the user to add the reader to the waiting list if the book is not available
        private void BtnOk_Click(object sender, EventArgs e)
        {

            Reader selectedReader = LbReaders.SelectedItem as Reader;
            Book selectedBook = LbBooks.SelectedItem as Book;

            //check if the date is set to a date after today to ensure all information is given by the user
            //(checking if an item is selected is the LB is unnecessary as there is always one selected)
            if (DateOnly.FromDateTime(DtpDueTo.Value).CompareTo(DateOnly.FromDateTime(DateTime.Today)) <= 0) 
            {
                MessageBox.Show("Please fill out all of the mandatory information!");
            }
            else 
            {
                if(control.AddBorrowEntry(selectedReader, selectedBook, DateOnly.FromDateTime(DtpDueTo.Value)))
                {
                    this.Close();
                }
                else
                {
                    //if the book is not available, the user will be asked if they want to add the reader to the waiting list of the book
                    var confirmResult = MessageBox.Show($"{selectedBook.Title} is not available right now\nDo you wish to add {selectedReader.Name} to the waiting list for this book", $"Add {selectedReader.Name} to waiting list", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        control.AddToWaitingList(selectedReader, selectedBook);
                        this.Close();
                    }
                    else 
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
