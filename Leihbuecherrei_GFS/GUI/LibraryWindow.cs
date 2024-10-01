using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;


        public LibraryWindow( Control pControl )
        {
            control = pControl;
            InitializeComponent();

        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Search Method can also be used to get all entries from the data base when searching for ""
            LbReaders.DataSource = control.SearchReader("");
            LbReaders.DisplayMember = "IdAndName";

            LbBooks.DataSource = control.LibraryWindowSearchBook("");
            LbBooks.DisplayMember = "IdAndTitle";
        }

        private void BtnAddBook_Click( object sender, EventArgs e )
        {
            AddBookWindow addBookWindow = new AddBookWindow(control);

            addBookWindow.Location = new Point(0, 0);
            addBookWindow.Show();
        }

        private void BtnAddReader_Click( object sender, EventArgs e )
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow(control);

            addReaderWindow.Location = new Point(0, 0);
            addReaderWindow.Show();
        }

        public void RefreshReadersList()
        {
            LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);
        }

        private async void LbReaders_DoubleClick( object sender, EventArgs e )
        {
            Reader selectedReader = LbReaders.SelectedItem as Reader;

            control.LibraryWindowLbReaders_DoubleClick(selectedReader);
        }

        private void LbBooks_DoubleClick( object sender, EventArgs e )
        {
            Book selectedBook = LbBooks.SelectedItem as Book;

            control.LibraryWindowLbBooks_DoubleClick(selectedBook);
        }

        private void BtnNewBorrowEntry_Click( object sender, EventArgs e )
        {
            AddBorrowEntryWindow addBorrowEntryWindow = new AddBorrowEntryWindow(control);

            addBorrowEntryWindow.Location = new Point(0, 0);
            addBorrowEntryWindow.Show();
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
                LbBooks.DataSource = control.LibraryWindowSearchBook(TxtSearchBook.Text);
            }
        }
    }
}