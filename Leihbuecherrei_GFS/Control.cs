using Leihbuecherrei_GFS.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        private LibraryWindow mainWindow;
        private PostgresDBContext database;

        public Control()
        {
            ApplicationConfiguration.Initialize();
            database = new PostgresDBContext();
            mainWindow = new LibraryWindow(this, database);
            Application.Run(mainWindow);
        }

        public bool AddReaderBtnSaveClick(string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
                //checks if the mandetory information is given if or returns false 
                if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { return false; }
                else
                {
                    // Compare methods returns an signed integer if the integer is less than 0 the first date is erlier than the second date
                    if (pBirthday.CompareTo(DateOnly.FromDateTime(DateTime.Today)) < 0)
                    {
                        database.Readers.Add(new Reader(pName, pAdress, pCity, pBirthday));
                    }
                    else
                    {
                        database.Readers.Add(new Reader(pName, pAdress, pCity));
                    }

                    database.SaveChanges();
                    mainWindow.RefreshReadersList();
                    return true;
                }
        }

        public bool AddBookBtnSaveClick( string pTitle, string pAuthor, string pPublisher)
        {
            //checks if the mandetory information is given if or returns false 
            if (String.IsNullOrEmpty(pTitle)) { return false; }
            else
            {
                database.Books.Add(new Book(pTitle, pAuthor, pPublisher));
                database.SaveChanges();
                //mainWindow.refreshReadersList();
                return true;
            }
        }

        public void LibraryWindowLbReaders_DoubleClick(Reader selectedReader) 
        {
            DisplayReadersWindow displayReaders = new DisplayReadersWindow(this, database.Readers.Find(selectedReader.Id));

            displayReaders.Location = new Point(0, 0);
            displayReaders.Show();
        }

        public bool DisplayReaderBtnSaveClick(Reader pReader, string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
            //finds the reader in the database and tracks it to make the changes
            pReader = database.Readers.Find(pReader.Id);

            //checks if the mandetory information is given if nor returns false 
            if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { return false; }
            else
            {    
                pReader.Name = pName;
                pReader.Address = pAdress;
                pReader.City = pCity;

                // Compare methods returns an signed integer if the integer is less than 0 the first date is erlier than the second date
                if (pBirthday.CompareTo(DateOnly.FromDateTime(DateTime.Today)) < 0)
                {
                    pReader.Birthday = pBirthday;
                }
                else
                {
                    // if the Birtdate is set to today or the future the Birthday atribute is set to null
                    pReader.Birthday = null; 
                }

                database.SaveChanges();
                mainWindow.RefreshReadersList();
                return true;
            }
        }

        public void DisplayReadersBtnDeleteClick(Reader pReader)
        {
            database.Readers.Remove(pReader);
            database.SaveChanges();
            //mainWindow.refreshReadersList();
        }

        public void LibraryWindowLbBooks_DoubleClick(Book selectedBook)
        {
            DisplayBookWindow displayBook = new DisplayBookWindow(this, database.Books.Find(selectedBook.Id));

            displayBook.Location = new Point(0, 0);
            displayBook.Show();
        }

        public bool DisplayBookBtnSaveClick(Book pBook, string pTitle, string pAuthor, string pPublisher)
        {
            //finds the reader in the database and tracks it to make the changes
            pBook = database.Books.Find(pBook.Id);

            //checks if the mandetory information is given if nor returns false 
            if (String.IsNullOrEmpty(pTitle)) { return false; }
            else
            {
                pBook.Title = pTitle;
                pBook.Author = pAuthor;
                pBook.Publisher = pPublisher;

                

                database.SaveChanges();
                //mainWindow.refreshReadersList();
                return true;
            }
        }

        public void DisplayBookBtnDeleteClick(Book pBook)
        {
            database.Books.Remove(pBook);
            database.SaveChanges();
        }
    }
}
