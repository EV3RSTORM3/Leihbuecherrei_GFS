using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class BorrowEntry
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public DateOnly BorrowedOn { get; set; }
        public DateOnly DueTo { get; set; }
        public bool Returned { get; set; }
        public DateOnly? ReturnedOn { get; set; }
        public bool Closed { get; set; }

        public BorrowEntry() { }

        public BorrowEntry( Book pBook, Reader pReader, DateOnly pDueTo )
        {
            Book = pBook;
            Reader = pReader;
            DueTo = pDueTo;
            BorrowedOn = DateOnly.FromDateTime(DateTime.Today);
            Returned = false;
            ReturnedOn = null;
            Closed = false;
        }
    }
}
