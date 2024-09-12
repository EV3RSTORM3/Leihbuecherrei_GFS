using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class BorrowEntry
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public DateTime BorrowedOn { get; set; }
        public DateTime DueTo { get; set; }
        public bool Closed { get; set; }

        public BorrowEntry() { }

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
