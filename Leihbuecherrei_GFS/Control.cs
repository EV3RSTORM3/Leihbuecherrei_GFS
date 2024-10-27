using Leihbuecherrei_GFS.GUI;
using Microsoft.EntityFrameworkCore;
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
                if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity)) 
                    return false;
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
                if (String.IsNullOrEmpty(pTitle)) 
                    return false;
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
                if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity))  
                    return false; 
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
                if (String.IsNullOrEmpty(pTitle)) 
                    return false;
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
            List<Reader> listReaders = new List<Reader>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                if(int.TryParse(pSearchFor, out int searchForID))
                {
                    listReaders.Add(database.Readers.Find(searchForID));
                }
                else
                {
                    listReaders = database.Readers.Where(r => r.Name.Contains(pSearchFor)).OrderByDescending(r => r.Id).ToList();
                }
            }
            return listReaders;
        }

        //Method to search for books without additional criteria
        public List<Book> SearchBook(string pSearchFor)
        {
            List<Book> listBooks = new List<Book>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                if (int.TryParse(pSearchFor, out int searchForId)) 
                { 
                    listBooks.Add(database.Books.Find(searchForId));
                }
                else
                {
                    listBooks = database.Books.Where(b => b.Title.Contains(pSearchFor)).OrderByDescending(b => b.Id).ToList();
                }
            }
            return listBooks;
        }

        //Extra method to search for books with the option to only show available books
        public List<Book> SearchBook(string pSearchFor, bool pIsAvailable)
        {
            List<Book> listBooks = new List<Book>();

            using (PostgresDBContext database = new PostgresDBContext())
            {
                if (int.TryParse(pSearchFor, out int searchForId))
                {
                    listBooks = database.Books.Where(b => b.Id == searchForId && b.Available == pIsAvailable).ToList();
                }
                else 
                {
                    listBooks = database.Books.Where(b => b.Title.Contains(pSearchFor) && b.Available == pIsAvailable).OrderByDescending(b => b.Id).ToList(); 
                }
            }
            return listBooks;
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
                mainWindow.RefreshBorrowEntryList();
            }
        }
        
        public List<BorrowEntry> LibraryWindowBtnBorrowEntrySearchClick(string pReader, string pBook, CheckState pClosed, CheckState pReturned)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {   
                //.include() tells EF to use Eager Loading which also loads the related entities
                //By using IQueriable I can build the query at runtime to take diffrent filter setting in to account
                //defines the query with the part it always needs already in it
                IQueryable<BorrowEntry> query = database.BorrowEntries.Include(be => be.Reader).Include(be => be.Book);

                if(string.IsNullOrEmpty(pReader) == false)
                {
                    if(int.TryParse(pReader, out int readerId))
                    {
                        query = query.Where(be => be.Reader.Id == readerId);
                    }
                    else
                    {
                        query = query.Where(be => be.Reader.Name.Contains(pReader));  
                    }
                }

                if (string.IsNullOrEmpty(pBook) == false)
                {
                    if (int.TryParse(pBook, out int bookId))
                    {
                        query = query.Where(be => be.Book.Id == bookId);
                    }
                    else
                    {
                        query = query.Where(be => be.Book.Title.Contains(pBook));
                    }
                }

                if (pClosed != CheckState.Indeterminate)
                {
                    if(pClosed == CheckState.Checked)
                    {
                        query = query.Where(be => be.Closed == true);
                    }
                    else
                    {
                        query = query.Where(be => be.Closed == false);
                    }
                }

                if (pReturned != CheckState.Indeterminate)
                {
                    if (pReturned == CheckState.Checked)
                    {
                        query = query.Where(be => be.Returned == true);
                    }
                    else
                    {
                        query = query.Where(be => be.Returned == false);
                    }
                }

                //executes the query and returns its results
                return query.ToList();
            }
        }

        public void LibraryWindowDgvBorrowEntries_DoubleClick(BorrowEntry selectedBorrowEntry)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayBorrowEntryWindow displayBorrowEntry = new DisplayBorrowEntryWindow(this, database.BorrowEntries.Include(be => be.Reader).Include(be => be.Book).First(be => be.Id == selectedBorrowEntry.Id));

                displayBorrowEntry.Location = new Point(0, 0);
                displayBorrowEntry.Show();
            }
        }
    }
}
