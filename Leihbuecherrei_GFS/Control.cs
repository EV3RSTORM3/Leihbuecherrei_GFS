using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        //BindingList supports binding with ListBox so you dont have to refresh the Listbox
        private BindingList<Book> books = new BindingList<Book>();
        private BindingList<Reader> reader = new BindingList<Reader>();  
        private LibraryWindow window; 

        public Control()
        {
            ApplicationConfiguration.Initialize();
            window = new LibraryWindow(this);
            Application.Run(window);
        }
        public BindingList<Book> GetBooks()
        {
            return books;
        }

        public BindingList<Reader> GetReaders()
        {
            return reader;
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
                }
                else
                {
                    reader.Add(new Reader(pName, pAdress, pCity));
                }
                return true;
            }
        }
    }
}
