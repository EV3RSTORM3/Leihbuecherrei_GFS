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
    public partial class AddReaderWindow : Form
    {
        private Control control;
        public AddReaderWindow(Control pControl)
        {
            control = pControl;
            InitializeComponent();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            if (control.addReaderBtnSaveClick(TxtName.Text, TxtAdress.Text, TxtCity.Text, DtpBirthday.Value) == false)
            {
                MessageBox.Show("please fill out every mandetory information!");
            }
            else
            {
                Close();
            }
        }

        private void DtpBirthday_ValueChanged( object sender, EventArgs e )
        {

        }
    }
}
