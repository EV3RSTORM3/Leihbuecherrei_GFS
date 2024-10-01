using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS
{
    [Table("readers")]
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<DateOnly> Birthday { get; set; }

        public Reader() { }

        public Reader( string pName, string pAddress, string pCity )
        {
            Name = pName;
            Address = pAddress;
            City = pCity;
            Birthday = null;
            
        }

        public Reader( string pName, string pAddress, string pCity, DateOnly pBirthday) : this(pName, pAddress, pCity)
        {
            Birthday = pBirthday;
        }

        //returns a string with Id and Name
        public string IdAndName 
        {
            get
            {
                return Id + " | " + Name;
            }
        }
    }
}
