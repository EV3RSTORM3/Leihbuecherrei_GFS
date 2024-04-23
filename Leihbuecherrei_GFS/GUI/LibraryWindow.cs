using Leihbuecherrei_GFS.GUI;

namespace Leihbuecherrei_GFS
{
    public partial class LibraryWindow : Form
    {
        private Control control;

        public LibraryWindow(Control pControl)
        {
            control = pControl;
            InitializeComponent();

            showReaderList();
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

            addReaderWindow.Location = new Point( 0, 0);
            addReaderWindow.Show();
        }

        public void showReaderList()
        {
            LbReaders.DataSource = control.GetReaders();

            LbReaders.DisplayMember = "Name";
        }
    }
}