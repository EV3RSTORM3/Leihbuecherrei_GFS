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
        public string? Author { get; set; } //? means that the value can be null
        public string? Publisher { get; set; } //? means that the value can be null
        public bool Available { get; set; }

        public Book() { } //empty constructor for Entity Framework

        public Book(string pTitle, string pAuthor, string pPublisher)
        {
            Title = pTitle;

            //checks for empty strings and sets the value to null if the string is empty
            if (String.IsNullOrEmpty(pAuthor))
            {
                Author = null;
            }
            else
            {
                Author = pAuthor;
            }

            //checks for empty strings and sets the value to null if the string is empty
            if (String.IsNullOrEmpty(pPublisher))
            {
                Publisher = null;
            }
            else
            {
                Publisher = pPublisher;
            }

            //sets the default value for Available to true
            Available = true;
        }

        public override string ToString()
        {
            return Id + " | " + Title;
        }
    }
}
