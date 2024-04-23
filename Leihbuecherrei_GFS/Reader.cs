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

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public Reader( string pName, string pAddress, string pCity )
        {
            Name = pName;
            Address = pAddress;
            City = pCity;
        }

        public Reader( string pName, string pAddress, string pCity, DateTime pBirthday) : this(pName, pAddress, pCity)
        {
            Birthday = pBirthday;
        }
    }
}
