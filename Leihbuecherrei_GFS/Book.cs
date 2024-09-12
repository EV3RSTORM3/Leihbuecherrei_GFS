using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public bool Available { get; set; }

        public Book() { }

        public Book(string pTitle, string pAuthor, string pPublisher)
        {
            Title = pTitle;
            Author = pAuthor;
            Publisher = pPublisher;
            Available = true;
        }
    }
}
