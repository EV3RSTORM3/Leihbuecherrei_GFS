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

        //this method is used to add a new reader to the database
        public bool AddReader(string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
            //checks if the mandetory information is given if or returns false 
            if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity))
            {
                return false;
            }

            using (PostgresDBContext database = new PostgresDBContext()) 
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
            }

            mainWindow.RefreshReadersList();
            return true;
        }

        //this method is used to add a new book to the database
        public bool AddBook(string pTitle, string pAuthor, string pPublisher)
        {
            //checks if the mandetory information is given if not returns false 
            if (String.IsNullOrEmpty(pTitle))
            {
                return false;
            }

            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.SaveChanges();
                database.Books.Add(new Book(pTitle, pAuthor, pPublisher));
            }

            mainWindow.RefreshBookList();
            return true;
        }

        //will find the reader in the database and display it in DisplayReaderWindow
        public void LibraryWindowDisplayReader(Reader selectedReader) 
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayReaderWindow displayReaders = new DisplayReaderWindow(this, database.Readers.Find(selectedReader.Id));

                displayReaders.Location = new Point(0, 0);
                displayReaders.ShowDialog();
            }
        }

        //this method is used to save the changes made to a reader in the database
        public bool DisplayReaderSave(Reader pReader, string pName, string pAdress, string pCity, DateOnly pBirthday)
        {
            //checks if the mandetory information is given if not returns false 
            if (String.IsNullOrEmpty(pName) || String.IsNullOrEmpty(pAdress) || String.IsNullOrEmpty(pCity))
            {
                return false;
            }

            using (PostgresDBContext database = new PostgresDBContext())
            {
                //finds the reader in the database and tracks it to make the changes
                pReader = database.Readers.Find(pReader.Id);

                //makes the changes to the Reader
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

        //this method is used to delete a reader from the database
        public void DisplayReaderDelete(Reader pReader)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.Readers.Remove(pReader);
                database.SaveChanges();
            }

            mainWindow.RefreshReadersList();            
        }

        //will find the book in the database and display it in DisplayBookWindow
        public void LibraryWindowDisplayBook(Book selectedBook)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayBookWindow displayBook = new DisplayBookWindow(this, database.Books.Find(selectedBook.Id));

                displayBook.Location = new Point(0, 0);
                displayBook.ShowDialog();
            }
        }

        //this method is used to save the changes made to a book in the database
        public bool DisplayBookSave(Book pBook, string pTitle, string pAuthor, string pPublisher)
        {
            //checks if the mandetory information is given if not returns false 
            if (String.IsNullOrEmpty(pTitle))
            {
                return false;
            }

            using (PostgresDBContext database = new PostgresDBContext())
            {
                //finds the reader in the database and tracks it to make the changes
                pBook = database.Books.Find(pBook.Id);

                //makes the Changes to the Book
                pBook.Title = pTitle;
                pBook.Author = pAuthor;
                pBook.Publisher = pPublisher;

                database.SaveChanges();
            }

            mainWindow.RefreshBookList();
            return true;
        }

        //this method is used to delete a book from the database
        public void DisplayBookDelete(Book pBook)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.Books.Remove(pBook);
                database.SaveChanges();
            }

            mainWindow.RefreshBookList();
        }

        //searches for readers with the name or ID given in the searchFor parameter
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
                    listReaders = database.Readers.Where(r => r.Name.Contains(pSearchFor)).OrderBy(r => r.Id).ToList();
                }
            }

            return listReaders;
        }

        //searches for books with the title or ID given in the searchFor parameter
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
                    listBooks = database.Books.Where(b => b.Title.Contains(pSearchFor)).OrderBy(b => b.Id).ToList();
                }
            }
            return listBooks;
        }

        //searches for books with the title or ID given in the searchFor parameter
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
                    listBooks = database.Books.Where(b => b.Title.Contains(pSearchFor) && b.Available == pIsAvailable).OrderBy(b => b.Id).ToList(); 
                }
            }
            return listBooks;
        }

        //this method is used to add a new BorrowEntry to the database
        public bool AddBorrowEntry(Reader pReader, Book pBook, DateOnly pDueTo)
        {
            bool returnValue = true;
            using (PostgresDBContext database = new PostgresDBContext())
            {
                //pbook and pReader have to be tracked trough EF so it knowes they exisit and doesn't try to add the to the database which returnes an error
                pBook = database.Books.Find(pBook.Id);
                pReader = database.Readers.Find(pReader.Id);

                if (pBook.Available)
                {
                    database.BorrowEntries.Add(new BorrowEntry(pBook, pReader, pDueTo));

                    pBook.Available = false;

                    database.SaveChanges();
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
            }

            mainWindow.RefreshBorrowEntryList();
            return returnValue;
        }

        //builds the query for the search using the secified parameters and returns the results
        public List<BorrowEntry> SearchBorrowEntry(string pReader, string pBook, CheckState pClosed, CheckState pReturned)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {   
                //.include() tells EF to use Eager Loading which also loads the related entities
                //can't use Lazy Loading here as the DataGridView doesn't support it
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

        public void DisplayBorrowEntry(BorrowEntry selectedBorrowEntry)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                DisplayBorrowEntryWindow displayBorrowEntry = new DisplayBorrowEntryWindow(this, database.BorrowEntries.Find(selectedBorrowEntry.Id));

                displayBorrowEntry.Location = new Point(0, 0);
                displayBorrowEntry.ShowDialog();
            }
        }

        public void DisplayBorrowEntryDelete(BorrowEntry pBorrowEntry)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                //gets the book from the database and sets it to available if its unavailability was due to the deleted BorrowEntry
                Book book = database.Books.Find(pBorrowEntry.Book.Id);
                if (!book.Available && !pBorrowEntry.Returned && !pBorrowEntry.Closed) 
                {
                    book.Available = true;

                    //Checks for reservation and tells the user to inform the next person on the Reservation list
                    List<Reservation> reservations = database.Reservations.Where(r => r.Book.Id == book.Id).OrderBy(r => r.Id).ToList();
                    if (reservations.Count > 0)
                    {
                        MessageBox.Show($"{reservations[0]} is next on the waiting list. Please notify him/her that the book is now available");
                        database.Reservations.Remove(reservations[0]);
                    }
                }
                database.BorrowEntries.Remove(pBorrowEntry);
                database.SaveChanges();
            }

            mainWindow.RefreshBorrowEntryList();
        }

        public bool DisplayBorrowEntrySave(BorrowEntry pBorrowEntry, Reader pReader, Book pBook, DateOnly pBorrowedOn, DateOnly pDueTo, bool pReturned, DateOnly? pReturnedOn, bool pClosed) 
        {
            if (pBorrowedOn.CompareTo(DateOnly.FromDateTime(DateTime.Today)) > 0)
            {
                return false; 
            }

            if (!pReturned)
            {
                pReturnedOn = null;
            }

            using (PostgresDBContext database = new PostgresDBContext())
            {
                //finds the BorrowEntry in the database and tracks it to make the changes
                pBorrowEntry = database.BorrowEntries.Find(pBorrowEntry.Id);

                //makes the changes to the BorrowEntry
                pBorrowEntry.Reader = pReader;
                pBorrowEntry.Book = pBook;
                pBorrowEntry.BorrowedOn = pBorrowedOn;
                pBorrowEntry.DueTo = pDueTo;
                pBorrowEntry.Returned = pReturned;
                pBorrowEntry.ReturnedOn = pReturnedOn;
                pBorrowEntry.Closed = pClosed;

                //cheks if the book is returned and sets the availability of the book accordingly
                if (pReturned)
                {
                    pBook.Available = true;

                    //Checks for reservation and tells the user to inform the next person on the Reservation list
                    List<Reservation> reservations = database.Reservations.Where(r => r.Book.Id == pBook.Id).OrderBy(r => r.Id).ToList();
                    if (reservations.Count > 0)
                    {
                        MessageBox.Show($"{reservations[0]} is next on the waiting list. Please notify him/her that the book is now available");
                        database.Reservations.Remove(reservations[0]);
                    }
                }
                else
                {
                    pBook.Available = false;
                }

                database.SaveChanges();
            }

            mainWindow.RefreshBorrowEntryList();
            return true;
        }

        public void AddToWaitingList( Reader pReader, Book pBook )
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                pBook = database.Books.Find(pBook.Id);
                pReader = database.Readers.Find(pReader.Id);

                database.Reservations.Add(new Reservation(pReader, pBook));

                database.SaveChanges();
            }
        }

        public void RemoveFromWaitinglist(Reservation pReservation) 
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                database.Reservations.Remove(pReservation);
                database.SaveChanges();
            }
        }

        //returns the waiting list for a book
        public List<Reservation> GetWaitinglist(Book pBook)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                return database.Reservations.Where(r => r.Book.Id == pBook.Id).OrderBy(r => r.Id).ToList();
            }
        }

        //returns the waiting list for a reader
        public List<Reservation> GetWaitinglist(Reader pReader)
        {
            using (PostgresDBContext database = new PostgresDBContext())
            {
                return database.Reservations.Where(r => r.Reader.Id == pReader.Id).OrderBy(r => r.Id).ToList();
            }
        }
    }
}
