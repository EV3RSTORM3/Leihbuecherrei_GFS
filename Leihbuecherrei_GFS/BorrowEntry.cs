using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    internal class BorrowEntry
    {
        private Book book;
        private Reader reader;
        private DateTime borrowedOn;
        private DateTime dueTo;
        private bool closed;

        public BorrowEntry( Book pBook, Reader pReader, DateTime pDueTo )
        {
            setBook(pBook);
            setReader(pReader);
            setDueTo(pDueTo);
            setBorrowedOn(DateTime.Now);
            setClosed(false);
        }

        // Getter and setter for 'book' parameter
        public Book getBook()
        {
            return book;
        }

        public void setBook( Book pBook )
        {
            book = pBook;
        }

        // Getter and setter for 'reader' parameter
        public Reader getReader()
        {
            return reader;
        }

        public void setReader( Reader pReader )
        {
            reader = pReader;
        }

        // Getter and setter for 'borrowedOn' parameter
        public DateTime getBorrowedOn()
        {
            return borrowedOn;
        }

        public void setBorrowedOn( DateTime pBorrowedOn )
        {
            borrowedOn = pBorrowedOn;
        }

        // Getter and setter for 'dueTo' parameter
        public DateTime getDueTo()
        {
            return dueTo;
        }

        public void setDueTo( DateTime pDueTo )
        {
            dueTo = pDueTo;
        }

        // Getter and setter for 'closed' parameter
        public bool getClosed()
        {
            return closed;
        }

        public void setClosed( bool pClosed )
        {
            closed = pClosed;
        }
    }
}
