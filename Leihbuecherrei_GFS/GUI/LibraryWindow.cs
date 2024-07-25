using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;
        private PostgresDBContext? dbContext;


        public LibraryWindow( Control pControl )
        {
            control = pControl;
            InitializeComponent();

            //bind the Readers list to the Listbox LbReaders. only has to be done once
            showReaderList();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            this.dbContext = new PostgresDBContext();
            this.dbContext.Readers.Load();
            this.readerBindingSource.DataSource = dbContext.Readers.Local.ToBindingList();
        }

        protected override void OnActivated( EventArgs e )
        {
            base.OnActivated(e);

            this.dbContext.Readers.Load();
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

        public void showReaderList()
        {
            //sets what atribute is shown in the ListBox. DisplayMember wont accept custom Getter thats why i have to use the autogenerated sytax for getter ans setter
            LbReaders.DisplayMember = "idAndName";
        }

        private void LbReaders_DoubleClick( object sender, EventArgs e )
        {
            Reader selectedReader = LbReaders.SelectedItem as Reader;

            DisplayReadersWindow displayReaders = new DisplayReadersWindow(control, selectedReader);

            displayReaders.Location = new Point(0, 0);
            displayReaders.Show();
        }
    }
}