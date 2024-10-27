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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (control.AddBookBtnSaveClick(TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                Close();
            }
            
        }
    }
}
