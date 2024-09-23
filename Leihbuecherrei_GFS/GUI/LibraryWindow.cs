using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;
        private PostgresDBContext database;


        public LibraryWindow( Control pControl, PostgresDBContext pDatabase )
        {
            control = pControl;
            database = pDatabase;
            InitializeComponent();

        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            database.Readers.Load();
            LbReaders.DataSource = database.Readers.Local.ToBindingList();
            LbReaders.DisplayMember = "IdAndName";

            database.Books.Load();
            LbBooks.DataSource = database.Books.Local.ToBindingList();
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
            database.ChangeTracker.Clear();
            database.Readers.Load();
            LbReaders.DataSource = database.Readers.Local.ToBindingList();
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
    }
}