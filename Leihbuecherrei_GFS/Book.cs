using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public bool Available { get; set; }

        public Book() { }

        public Book(string pTitle, string pAuthor, string pPublisher)
        {
            Title = pTitle;

            if (String.IsNullOrEmpty(pAuthor)) { Author = null; }
            else { Author = pAuthor; }

            if (String.IsNullOrEmpty(pPublisher)) { Publisher = null; }
            else {  Publisher = pPublisher; }

            Available = true;
        }


        //returns a string with Id and Name
        public string IdAndTitle
        {
            get
            {
                return Id + "\t" + Title;
            }
        }
    }
}
