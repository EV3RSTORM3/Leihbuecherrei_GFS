using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;
        private PostgresDBContext database;


        public LibraryWindow( Control pControl, PostgresDBContext pDatabase)
        {
            control = pControl;
            database = pDatabase;
            InitializeComponent();

        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            this.database.Readers.Load();
            LbReaders.DataSource = database.Readers.Local.ToBindingList();

            LbReaders.DisplayMember = "idAndName";
        }

        private void BtnAddBook_Click( object sender, EventArgs e )
        {
            AddBookWindow addBookWindow = new AddBookWindow();

            addBookWindow.Location = new Point(0, 0);
            addBookWindow.Show();
        }

        private void BtnAddReader_Click( object sender, EventArgs e )
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow(control);

            addReaderWindow.Location = new Point(0, 0);
            addReaderWindow.Show();
        }

        public void refreshReadersList()
        {                                                                                                                                              
            database.ChangeTracker.Clear();
            LbReaders.DataSource = database.Readers.Local.ToBindingList();
        }

        private async void LbReaders_DoubleClick( object sender, EventArgs e )
        {
            Reader selectedReader = LbReaders.SelectedItem as Reader;

            control.libraryWindowLbReaders_DoubleClick(selectedReader);
        }
    }
}