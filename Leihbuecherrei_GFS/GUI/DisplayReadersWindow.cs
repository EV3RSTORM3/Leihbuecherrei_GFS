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
            reader = pReader;
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            Text = reader.Name;

            TxtName.Text = reader.Name;
            TxtId.Text = Convert.ToString(reader.Id);
            TxtCity.Text = reader.City;
            TxtAdress.Text = reader.Address;

            //?? handles the possibility of Birthday being null
            DateOnly temp = reader.Birthday ?? DateOnly.FromDateTime(DateTime.Now);

            //Have to Add a TimeOnly to the DateOnly to make a DateTime, because WinForms DateTimepicker only accepts DateTime variables
            DtpBirthday.Value = temp.ToDateTime(new TimeOnly(0, 0));

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnSave.Enabled = false;
            BtnSaveAndClose.Enabled = false;
        }

        private void TxtAdress_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void TxtName_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void DtpBirthday_ValueChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void TxtCity_TextChanged( object sender, EventArgs e )
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            control.DisplayReaderBtnSaveClick(reader, TxtName.Text, TxtAdress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value));

            //refreshes the title of the window after save
            this.Text = reader.Name;
        }

        private void BtnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void BtnSaveAndClose_Click( object sender, EventArgs e )
        {
            control.DisplayReaderBtnSaveClick(reader, TxtName.Text, TxtAdress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value));
            this.Close();
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                control.DisplayReadersBtnDeleteClick(reader);
                this.Close();
            }
        }
    }
}
