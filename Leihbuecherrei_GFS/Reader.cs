using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Reader
    {
        private string name;
        private string address;
        private string city;
        private DateTime birthday;
        private static int nextId = 0;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Id { get => id;}

        public Reader( string pName, string pAddress, string pCity )
        {
            Name = pName;
            Address = pAddress;
            City = pCity;
            Birthday = DateTime.MinValue;
            id = nextId++;
        }

        public Reader( string pName, string pAddress, string pCity, DateTime pBirthday) : this(pName, pAddress, pCity)
        {
            Birthday = pBirthday;
        }

        public string idAndName 
        {
            get
            {
                return Id + "\t" + Name;
            }
        }
    }
}
