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

            //sets the DateTimePicker to show nothing
            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.CustomFormat = " ";
        }

        //adds the new reader after checking if all mandatory fields are filled out
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (control.AddReader(TxtName.Text, TxtAddress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandatory information!");
            }
            else
            {
                this.Close();
            }
        }

        //if the user enters the DateTimePicker, the DateTimePicker will show the date
        private void DtpBirthday_Enter(object sender, EventArgs e)
        {
            DtpBirthday.Format = DateTimePickerFormat.Short;
        }

        //if the user leaves the DateTimePicker without selecting a date, the DateTimePicker will show nothing
        private void DtpBirthday_Leave(object sender, EventArgs e)
        {
            if (DateOnly.FromDateTime(DtpBirthday.Value).CompareTo(DateOnly.FromDateTime(DateTime.Today)) >= 0)
            {
                DtpBirthday.Format = DateTimePickerFormat.Custom;
                DtpBirthday.CustomFormat = " ";
            }

            //focuses the OK button when the user leaves the control using tab as the focus would not be transfered if using the tab button normally probably due to the changing of the format
            this.BtnOk.Focus();
        }
    }
}
