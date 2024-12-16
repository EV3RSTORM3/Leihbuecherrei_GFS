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
        public DateOnly? Birthday { get; set; } //? means that the value can be null

        public Reader() { } //empty constructor for Entity Framework

        public Reader(string pName, string pAddress, string pCity)
        {
            Name = pName;
            Address = pAddress;
            City = pCity;
            //if the birthday is not set, it will be null
            Birthday = null;
        }

        public Reader(string pName, string pAddress, string pCity, DateOnly pBirthday) : this(pName, pAddress, pCity)
        {
            Birthday = pBirthday;
        }

        public override string ToString()
        {
            return Id + " | " + Name;
        }
    }
}
