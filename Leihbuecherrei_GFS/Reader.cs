using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    internal class Reader
    {
        private string name;
        private string address;
        private string city;
        private DateTime birthday;

        public Reader( string pName, string pAddress, string pCity )
        {
            setName(pName);
            setAdress(pAddress);
            setCity(pCity);
        }

        public Reader( string pName, string pAddress, string pCity, DateTime pBirthday) : this(pName, pAddress, pCity)
        {
            setBirthday(pBirthday);
        }

        //Getter and Setter for 'name' parameter
        public void setName( string pName )
        {
            name = pName;
        }

        public string getName()
        {
            return name;
        }

        //Getter and Setter for 'address' parameter
        public void setAdress( string pAddress )
        {
            address = pAddress;
        }

        public string getAdress()
        {
            return address;
        }

        //Getter and Setter for 'City' parameter
        public void setCity( string pCity )
        {
            city = pCity;
        }

        public string getCity()
        {
            return city;
        }

        //Getter and Setter for 'birthday' parameter
        public void setBirthday( DateTime pBirthday )
        {
            birthday = pBirthday;
        }

        public DateTime getBirthday()
        {
            return birthday;
        }
    }
}
