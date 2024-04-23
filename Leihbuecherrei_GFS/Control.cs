using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        private List<Book> books = new List<Book>();
        private List<Reader> reader = new List<Reader>();

        public Control()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LibraryWindow(this));
        }

        public bool addReaderBtnSaveClick( string pName, string pAdress, string pCity, DateTime pBirthday )
        {
            if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { return false; }
            else
            {
                // Compare methods returns an signed integer if the integer is less than 0 the first date is erlier than the second date
                if (DateTime.Compare(pBirthday, DateTime.Today) < 0)
                {
                    reader.Add(new Reader(pName, pAdress, pCity, pBirthday));
                    return true;
                }
                else
                {
                    reader.Add(new Reader(pName, pAdress, pCity));
                    return true;
                }
            }
        }
    }
}
