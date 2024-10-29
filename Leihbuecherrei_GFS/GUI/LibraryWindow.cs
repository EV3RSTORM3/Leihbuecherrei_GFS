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

            //Search Method can also be used to get all entries from the data base when searching for ""
            LbReaders.DataSource = control.SearchReader("");
            LbBooks.DataSource = control.SearchBook("");
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow(control);

            addBookWindow.Location = new Point(0, 0);
            addBookWindow.Show();
        }

        private void BtnAddReader_Click(object sender, EventArgs e)
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow(control);

            addReaderWindow.Location = new Point(0, 0);
            addReaderWindow.Show();
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
            DgvBorrowEntries.DataSource = control.LibraryWindowSearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        private async void LbReaders_DoubleClick(object sender, EventArgs e)
        {
            Reader selectedReader = LbReaders.SelectedItem as Reader;

            control.LibraryWindowDisplayReader(selectedReader);
        }

        private void LbBooks_DoubleClick(object sender, EventArgs e)
        {
            Book selectedBook = LbBooks.SelectedItem as Book;

            control.LibraryWindowDisplayBook(selectedBook);
        }

        private void BtnNewBorrowEntry_Click(object sender, EventArgs e)
        {
            AddBorrowEntryWindow addBorrowEntryWindow = new AddBorrowEntryWindow(control);

            addBorrowEntryWindow.Location = new Point(0, 0);
            addBorrowEntryWindow.Show();
        }

        private void TxtSearchReader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);
            }
        }

        private void TxtSearchBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text);
            }
        }

        private void BtnBorrowEntrySearch_Click(object sender, EventArgs e)
        {
            DgvBorrowEntries.DataSource = control.LibraryWindowSearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }

        private void DgvBorrowEntries_DoubleClick(object sender, EventArgs e)
        {
            //Gets the selected BorrowEntry
            BorrowEntry selectedBorrowEntry = DgvBorrowEntries.SelectedRows[0].DataBoundItem as BorrowEntry;

            control.LibraryWindowDisplayBorrowEntry(selectedBorrowEntry);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtSearchBorrowEntryReader.Text = string.Empty;
            TxtSearchBorrowEntryBook.Text = string.Empty;

            //Indeterminate is the default state in which the filter is ignored
            CbClosed.CheckState = CheckState.Indeterminate;
            CbReturned.CheckState = CheckState.Indeterminate;

            DgvBorrowEntries.DataSource = control.LibraryWindowSearchBorrowEntry(TxtSearchBorrowEntryReader.Text, TxtSearchBorrowEntryBook.Text, CbClosed.CheckState, CbReturned.CheckState);
        }
    }
}