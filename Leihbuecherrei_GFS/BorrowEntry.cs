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

        //When Virtual is used, the property is not loaded with the object but when it is accessed(Lazy Loading)
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
        public DateOnly BorrowedOn { get; set; }
        public DateOnly DueTo { get; set; }
        public bool Returned { get; set; }
        public DateOnly? ReturnedOn { get; set; } //? means that the value can be null
        public bool Closed { get; set; }

        public BorrowEntry() { } //empty constructor for Entity Framework

        public BorrowEntry(Book pBook, Reader pReader, DateOnly pDueTo)
        {
            Book = pBook;
            Reader = pReader;
            DueTo = pDueTo;

            //sets the deafult values for the other properties
            BorrowedOn = DateOnly.FromDateTime(DateTime.Today);
            Returned = false;
            ReturnedOn = null;
            Closed = false;
        }
    }
}
