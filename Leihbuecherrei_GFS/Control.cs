using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
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
       
        public Control()
        {
            ApplicationConfiguration.Initialize();
            mainWindow = new LibraryWindow(this);
            Application.Run(mainWindow);
        }

        public bool AddReaderBtnSaveClick(string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
            using (PostgresDBContext database = new PostgresDBContext()) {
                //checks if the mandetory information is given if or returns false 
                if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { return false; }
                else
                {
                    //Compare methods returns an signed integer if the integer is less than 0 the first date is earlier than the second date
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
        }

        public bool AddBookBtnSaveClick( string pTitle, string pAuthor, string pPublisher)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                //checks if the mandetory information is given if not returns false 
                if (String.IsNullOrEmpty(pTitle)) { return false; }
                else
                {
                    database.Books.Add(new Book(pTitle, pAuthor, pPublisher));
                    database.SaveChanges();

                    mainWindow.RefreshBookList();
                    return true;
                }
            }
        }

        public void LibraryWindowLbReaders_DoubleClick(Reader selectedReader) 
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayReadersWindow displayReaders = new DisplayReadersWindow(this, database.Readers.Find(selectedReader.Id));

                displayReaders.Location = new Point(0, 0);
                displayReaders.Show();
            }
        }

        public bool DisplayReaderBtnSaveClick(Reader pReader, string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                //finds the reader in the database and tracks it to make the changes
                pReader = database.Readers.Find(pReader.Id);

                //checks if the mandetory information is given if not returns false 
                if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) { return false; }
                else
                {
                    pReader.Name = pName;
                    pReader.Address = pAdress;
                    pReader.City = pCity;

                    //Compare methods returns an signed integer if the integer is less than 0 the first date is earlier than the second date
                    if (pBirthday.CompareTo(DateOnly.FromDateTime(DateTime.Today)) < 0)
                    {
                        pReader.Birthday = pBirthday;
                    }
                    else
                    {
                        //if the Birthdate is set to today or the future the Birthday atribute is set to null
                        pReader.Birthday = null;
                    }

                    database.SaveChanges();
                }

                mainWindow.RefreshReadersList();
                return true;
            }
        }

        public void DisplayReadersBtnDeleteClick(Reader pReader)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.Readers.Remove(pReader);
                database.SaveChanges();
            }
            mainWindow.RefreshReadersList();            
        }

        public void LibraryWindowLbBooks_DoubleClick(Book selectedBook)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayBookWindow displayBook = new DisplayBookWindow(this, database.Books.Find(selectedBook.Id));

                displayBook.Location = new Point(0, 0);
                displayBook.Show();
            }
        }

        public bool DisplayBookBtnSaveClick(Book pBook, string pTitle, string pAuthor, string pPublisher)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                //finds the reader in the database and tracks it to make the changes
                pBook = database.Books.Find(pBook.Id);

                //checks if the mandetory information is given if not returns false 
                if (String.IsNullOrEmpty(pTitle)) { return false; }
                else
                {
                    pBook.Title = pTitle;
                    pBook.Author = pAuthor;
                    pBook.Publisher = pPublisher;



                    database.SaveChanges();
                    mainWindow.RefreshBookList();
                    return true;
                }
            }
        }

        public void DisplayBookBtnDeleteClick(Book pBook)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.Books.Remove(pBook);
                database.SaveChanges();
            }
            mainWindow.RefreshBookList();
        }

        //can be used for all searches for readers as there are no usecases where more criteria are set
        public List<Reader> SearchReader(string pSearchFor) 
        {
            List<Reader> list = new List<Reader>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                try
                {
                    list.Add(database.Readers.Find(Convert.ToInt32(pSearchFor)));
                }
                catch (FormatException)
                {
                    list = database.Readers.Where(r => r.Name.Contains(pSearchFor)).OrderByDescending(r => r.Id).ToList();
                }
            }
            return list;
        }

        public List<Book> LibraryWindowSearchBook(string pSearchFor)
        {
            List<Book> list = new List<Book>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                try
                {
                    list.Add(database.Books.Find(Convert.ToInt32(pSearchFor)));
                }
                catch (FormatException)
                {
                    list = database.Books.Where(b => b.Title.Contains(pSearchFor)).OrderByDescending(b => b.Id).ToList();
                }
            }
            return list;
        }

        //When searching for books to borow it only returns books that meet the search criteria and are available
        public List<Book> BorrowEntrySearchBook(string pSearchFor)
        {
            List<Book> list = new List<Book>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                try
                {
                    int searchForId = Convert.ToInt32(pSearchFor);
                    list = database.Books.Where(b => b.Id == searchForId && b.Available == true).ToList();
                }
                catch (FormatException)
                {
                    list = database.Books.Where(b => b.Title.Contains(pSearchFor) && b.Available == true).OrderByDescending(b => b.Id).ToList();
                }
            }
            return list;
        }

        public void AddBorrowEntryBtnSaveClick(Reader pReader, Book pBook, DateOnly pDueTo)
        {
            using (PostgresDBContext databse = new PostgresDBContext())
            {
                //pbook and pReader have to be tracked trough EF so it knowes they exisit and doesn't try to add the to the database which returnes an error
                pBook = databse.Books.Find(pBook.Id);
                pReader = databse.Readers.Find(pReader.Id);

                databse.BorrowEntries.Add(new BorrowEntry(pBook, pReader, pDueTo));
                databse.SaveChanges();
                //mainWindow.RefreshBorrowEntryList();
            }
        }
    }
}
