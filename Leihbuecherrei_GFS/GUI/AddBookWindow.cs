using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS.GUI
{
    public partial class AddBookWindow : Form
    {
        private Control control;

        public AddBookWindow(Control pControl)
        {
            control = pControl;
            InitializeComponent();
        }

        //adds the new book after checking if all mandatory fields are filled out
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //AddBook Method returns false if not all mandatory fields are filled out
            if (control.AddBook(TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandatory information!");
            }
            else
            {
                Close();
            }
            
        }
    }
}
