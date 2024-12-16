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
    public partial class AddToWaitingListWindow : Form
    {
        private Control control;
        public AddToWaitingListWindow( Control pControl )
        {
            control = pControl;
            InitializeComponent();
        }

        //will be used if the user adds a reservation from the DisplayBookWindow
        public AddToWaitingListWindow( Book pBook, Control pControl ) : this(pControl)
        {
            //Sets the book for which a reservation is going to be made
            LbBooks.Items.Add(pBook);
            LbBooks.SelectedIndex = 0;
            //Loads the Readers so the user can select the reader for the reservation
            LbReaders.DataSource = control.SearchReader("");
        }

        //will be used if the user adds a reservation from the DisplayReaderWindow
        public AddToWaitingListWindow( Reader pReader, Control pControl ) : this(pControl)
        {
            //Sets the reader for which a reservation is going to be made
            LbReaders.Items.Add(pReader);
            LbReaders.SelectedIndex = 0;
            //Loads the Books so the user can select the book for the reservation
            LbBooks.DataSource = control.SearchBook("");
        }

        //starts the search if the user hits enter
        private void TxtSearchReader_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbReaders.DataSource = control.SearchReader(TxtSearchReader.Text);

                //focuses LbReaders after the user hits enter to search
                this.LbReaders.Focus();
            }
        }

        //starts the search if the user hits enter
        private void TxtSearchBook_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LbBooks.DataSource = control.SearchBook(TxtSearchBook.Text);
                //focuses LbBooks after the user hits enter to search
                this.LbBooks.Focus();
            }
        }

        //adds the reservation
        private void BtnOk_Click( object sender, EventArgs e )
        {
            control.AddToWaitingList(LbReaders.SelectedItem as Reader, LbBooks.SelectedItem as Book);
            this.Close();
        }
    }
}
