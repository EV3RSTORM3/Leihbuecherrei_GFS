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
    public partial class DisplayBookWindow : Form
    {
        private Control control;
        private Book book;

        public DisplayBookWindow(Control pControl, Book pBook)
        {
            control = pControl;
            book = pBook;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //sets the title of the window to the title of the book
            this.Text = book.Title;

            TxtTitle.Text = book.Title;
            TxtId.Text = Convert.ToString(book.Id);
            TxtPublisher.Text = book.Publisher;
            TxtAuthor.Text = book.Author;

            //Save button has to be disabled after initializing the data because TextChanged methods detect the initialization as changed
            BtnApply.Enabled = false;
            BtnOk.Enabled = false;
        }

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged(object sender, EventArgs e)
        {
            BtnApply.Enabled = true;
            BtnOk.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (control.DisplayBookSave(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                //refreshes the title of the window after save
                this.Text = TxtTitle.Text;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (control.DisplayBookSave(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
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
                control.DisplayBookDelete(book);
                this.Close();
            }
        }
    }
}
