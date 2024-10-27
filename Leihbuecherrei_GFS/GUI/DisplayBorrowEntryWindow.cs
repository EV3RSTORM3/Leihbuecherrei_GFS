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
    public partial class DisplayBorrowEntryWindow : Form
    {
        private Control control;
        private BorrowEntry borrowEntry;

        public DisplayBorrowEntryWindow(Control pControl, BorrowEntry pBorrowEntry)
        {
            control = pControl;
            borrowEntry = pBorrowEntry;
            InitializeComponent();
            Inizialize();
        }

        private void Inizialize()
        {
            LbBooks.DataSource = control.SearchBook(Convert.ToString(borrowEntry.Book.Id));
            LbReaders.DataSource = control.SearchReader(Convert.ToString(borrowEntry.Reader.Id));

            DtpBorrowedOn.Value = borrowEntry.BorrowedOn.ToDateTime(new TimeOnly(0, 0));

            DtpDueTo.Value = borrowEntry.DueTo.ToDateTime(new TimeOnly(0, 0));

            CbReturned.Checked = borrowEntry.Returned;
            if (!borrowEntry.Returned)
            {
                //disables and showes nothing in the DateTimePicker when returned is false which means ReturnedOn is null
                DtpReturnedOn.Enabled = false;
                DtpReturnedOn.Format = DateTimePickerFormat.Custom;
                DtpReturnedOn.CustomFormat = " ";
            }
            else
            {
                //?? handles the possibility of ReturnedOn being null
                DtpReturnedOn.Value = borrowEntry.ReturnedOn?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Now;
            }

            CbClosed.Checked = borrowEntry.Closed;

            BtnSave.Enabled = false;
            BtnSaveAndClose.Enabled = false;
        }
    }
}
