using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        //BindingList supports binding with ListBox so you dont have to refresh the Listbox
        private BindingList<Book> books = new BindingList<Book>();
        private BindingList<Reader> reader = new BindingList<Reader>();  
        private LibraryWindow mainWindow; 

        public Control()
        {
            ApplicationConfiguration.Initialize();
            mainWindow = new LibraryWindow(this);
            Application.Run(mainWindow);
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
            //checks if the mandetory information is given if nor returns false 
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

        public void DisplayReaderBtnSaveClick( Reader pReader, string pName, string pAdress, string pCity, DateTime pBirthday )
        {
            //checks if the mandetory information is given if nor returns false 
            if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { MessageBox.Show("please fill out all of th mandetory information!"); }
            else
            {
                pReader.Name = pName;
                pReader.Address = pAdress;
                pReader.City = pCity;

                // Compare methods returns an signed integer if the integer is less than 0 the first date is erlier than the second date
                if (DateTime.Compare(pBirthday, DateTime.Today) < 0)
                {
                    pReader.Birthday = pBirthday;
                }
                else
                {
                    // if the Birtdate is set to today or the future the Birthday atribute is filled with the MinValue of DateTime, which is also used by the Readers constructor
                    pReader.Birthday = DateTime.MinValue; 
                }

                mainWindow.showReaderList(); // can also be used to refresh the listbox
            }
        }
    }
}
