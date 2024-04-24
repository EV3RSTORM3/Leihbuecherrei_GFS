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

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public bool Available { get => available; set => available = value; }

        public Book(string pTitle, string pAuthor, string pPublisher)
        {
            Title = pTitle;
            Author = pAuthor;
            Publisher = pPublisher;
            Available = true;
        }
    }
}
