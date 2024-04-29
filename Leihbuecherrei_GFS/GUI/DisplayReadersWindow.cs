using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leihbuecherrei_GFS.GUI
{
    public partial class DisplayReadersWindow : Form
    {
        private Control control;
        private Reader reader;

        public DisplayReadersWindow( Control pControl, Reader pReader )
        {
            control = pControl;
            InitializeComponent();

            reader = pReader;

            initialize();
        }

        private void initialize()
        {
            this.Text = reader.Name;

            TxtName.Text = reader.Name;
            TxtId.Text = Convert.ToString(reader.Id);
            TxtCity.Text = reader.City;
            TxtAdress.Text = reader.Address;

            if (DateTime.Compare(reader.Birthday, DtpBirthday.MinDate) < 0)
            {
                DtpBirthday.Value = DateTime.Today;
            }
            else
            {
                DtpBirthday.Value = reader.Birthday;
            }

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnSave.Enabled = false; 
        }

        private void TxtAdress_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
        }

        private void TxtName_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
        }

        private void DtpBirthday_ValueChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
        }

        private void TxtCity_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            control.DisplayReaderBtnSaveClick(reader, TxtName.Text, TxtAdress.Text, TxtCity.Text, DtpBirthday.Value);
            
            //refreshes the title of the window after save
            this.Text = reader.Name;
        }
    }
}
