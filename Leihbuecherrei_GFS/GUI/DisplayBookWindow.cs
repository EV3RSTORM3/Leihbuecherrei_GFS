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
            BtnSave.Enabled = false;
            BtnSaveAndClose.Enabled = false;
        }

        //activates the save buttons whe the content of the window is changed
        private void ContentChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            BtnSaveAndClose.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Changes will be discarded", "Close this Window?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (control.DisplayBookBtnSaveClick(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
            {
                MessageBox.Show("Please fill out all of the mandetory information!");
            }
            else
            {
                //refreshes the title of the window after save
                this.Text = TxtTitle.Text;
            }
        }

        private void BtnSaveAndClose_Click(object sender, EventArgs e)
        {
            if (control.DisplayBookBtnSaveClick(book, TxtTitle.Text, TxtAuthor.Text, TxtPublisher.Text) == false)
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
                control.DisplayBookBtnDeleteClick(book);
                this.Close();
            }
        }
    }
}
