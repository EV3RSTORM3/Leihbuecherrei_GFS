using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Reservation
    {
        public int Id { get; set; }
        public virtual Reader Reader { get; set; }
        public virtual Book Book { get; set; }

        public Reservation() { }

        public Reservation(Reader pReader, Book pBook) 
        {
            Reader = pReader;
            Book = pBook;
        }
    }
}
