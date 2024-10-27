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

            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.CustomFormat = " ";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (control.AddReaderBtnSaveClick(TxtName.Text, TxtAdress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
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
        }
    }
}
