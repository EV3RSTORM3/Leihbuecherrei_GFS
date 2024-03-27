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
        }

        private void splitContainer1_Panel1_Paint( object sender, PaintEventArgs e )
        {

        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }


        private void BtnAddBook_Click( object sender, EventArgs e )
        {
            AddBookWindow addBookWindow = new AddBookWindow();

            addBookWindow.Location = new Point(0, 0);
            addBookWindow.Show();
        }

        private void BtnAddReader_Click( object sender, EventArgs e )
        {
            AddReaderWindow addReaderWindow = new AddReaderWindow();

            addReaderWindow.Location = new Point( 0, 0);
            addReaderWindow.Show();
        }
    }
}