using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class BorrowEntry
    {
        private Book book;
        private Reader reader;
        private DateTime borrowedOn;
        private DateTime dueTo;
        private bool closed;

        public Book Book { get => book; set => book = value; }
        public Reader Reader { get => reader; set => reader = value; }
        public DateTime BorrowedOn { get => borrowedOn; set => borrowedOn = value; }
        public DateTime DueTo { get => dueTo; set => dueTo = value; }
        public bool Closed { get => closed; set => closed = value; }

        public BorrowEntry( Book pBook, Reader pReader, DateTime pDueTo )
        {
            Book = pBook;
            Reader = pReader;
            DueTo = pDueTo;
            BorrowedOn = DateTime.Today;
            Closed = false;
        }
    }
}
