using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private bool available;

        public Book(string pTitle, string pAuthor, string pPublisher)
        {
            setTitle(pTitle);
            setAuthor(pAuthor);
            setPublisher(pPublisher);
            setAvailable(true);
        }

        // Getter and setter for 'title' parameter
        public string getTitle()
        {
            return title;
        }

        public void setTitle( string pTitle )
        {
            title = pTitle;
        }

        // Getter and setter for 'author' parameter
        public string getAuthor()
        {
            return author;
        }

        public void setAuthor( string pAuthor )
        {
            author = pAuthor;
        }

        // Getter and setter for 'publisher' parameter
        public string getPublisher()
        {
            return publisher;
        }

        public void setPublisher( string pPublisher )
        {
            publisher = pPublisher;
        }

        // Getter and setter for 'available' parameter
        public bool getAvailable()
        {
            return available;
        }

        public void setAvailable( bool pAvailable )
        {
            available = pAvailable;
        }
    }
}
