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

        public DisplayReadersWindow(Control pControl, Reader pReader)
        {
            control = pControl;
            reader = pReader;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //sets the title of the window to the name of the reader
            this.Text = reader.Name;

            TxtName.Text = reader.Name;
            TxtId.Text = Convert.ToString(reader.Id);
            TxtCity.Text = reader.City;
            TxtAdress.Text = reader.Address;
            
            //?? handles the possibility of Birthday being null
            //Have to Add a TimeOnly to the DateOnly to make a DateTime, because WinForms DateTimepicker only accepts DateTime variables
            DtpBirthday.Value = reader.Birthday?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Today;

            if (reader.Birthday == null) 
            {
                DtpBirthday.Format = DateTimePickerFormat.Custom;
                DtpBirthday.CustomFormat = " ";
            }

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnSave.Enabled = false;
            BtnSaveAndClose.Enabled = false;
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

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (control.DisplayReaderBtnSaveClick(reader, TxtName.Text, TxtAdress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                //refreshes the title of the window after save
                this.Text = TxtName.Text;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (control.DisplayReaderBtnSaveClick(reader, TxtName.Text, TxtAdress.Text, TxtCity.Text, DateOnly.FromDateTime(DtpBirthday.Value)) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                this.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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
