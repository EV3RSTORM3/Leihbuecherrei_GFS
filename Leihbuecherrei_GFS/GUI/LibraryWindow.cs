using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;

        public LibraryWindow(Control pControl)
        {
            control = pControl;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Search Method can also be used to get all entries from the data base when searching for an Empty string
            LbReaders.DataSource = control.SearchReader(string.Empty);
            LbBooks.DataSource = control.SearchBook(string.Empty);

            //Initializes the BorrowEntry DataGridView
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(string.Empty, string.Empty, CheckState.Indeterminate, CheckState.Indeterminate);
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow(control);

            addBookWindow.Location = new Point(0, 0);
            addBookWindow.ShowDialog();
        }

        private void BtnAddReader_Click(object sender, EventArgs e)
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow(control);

            addReaderWindow.Location = new Point(0, 0);
            addReaderWindow.ShowDialog();
        }

        public void RefreshReadersList()
        {
            LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);
        }

        public void RefreshBookList()
        {
            LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text);
        }

        public void RefreshBorrowEntryList()
        {
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        //opens the selected reader in a new window
        private void LbReaders_DoubleClick(object sender, EventArgs e)
        {
            Reader selectedReader = LbReaders.SelectedItem as Reader;

            control.LibraryWindowDisplayReader(selectedReader);
        }

        //opens the selected book in a new window
        private void LbBooks_DoubleClick(object sender, EventArgs e)
        {
            Book selectedBook = LbBooks.SelectedItem as Book;

            control.LibraryWindowDisplayBook(selectedBook);
        }

        private void BtnNewBorrowEntry_Click(object sender, EventArgs e)
        {
            AddBorrowEntryWindow addBorrowEntryWindow = new AddBorrowEntryWindow(control);

            addBorrowEntryWindow.Location = new Point(0, 0);
            addBorrowEntryWindow.ShowDialog();
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

        //starts the search if the user hits search button
        private void BtnBorrowEntrySearch_Click(object sender, EventArgs e)
        {
            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        //opens the selected BorrowEntry in a new window
        private void DgvBorrowEntries_DoubleClick(object sender, EventArgs e)
        {
            //Gets the selected BorrowEntry
            BorrowEntry selectedBorrowEntry = DgvBorrowEntries.SelectedRows[0].DataBoundItem as BorrowEntry;

            control.DisplayBorrowEntry(selectedBorrowEntry);
        }

        //resets the filters for the BorrowEntry search and shows all entries
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtSearchBorrowEntryReader.Text = string.Empty;
            TxtSearchBorrowEntryBook.Text = string.Empty;

            //Indeterminate is the default state in which the filter is ignored
            CbClosed.CheckState = CheckState.Indeterminate;
            CbReturned.CheckState = CheckState.Indeterminate;

            DgvBorrowEntries.DataSource = control.SearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }
    }
}