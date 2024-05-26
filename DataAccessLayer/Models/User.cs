using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;



namespace DataAccessLayer.Models

{
    public class User : IUser
    { 
        public string Password { get; set; }
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<IBook> BorrowedBook { get; set; }//= new List<IBook>();// books borrowed at the moment
        public ICollection<IBook> AllBooks { get; set; }//= new List<IBook>(); //All the borrowed books
        //public List<IBook> BorrowedBook { get; set; }
        public User() { }
        public User(string password, Guid iD, string email, string name, ICollection<IBook> borrowedBook, ICollection<IBook> allbooks)
        {
            Password = password;
            Id = iD;
            Email = email;
            Name = name;
            BorrowedBook = borrowedBook;
            AllBooks = allbooks;
        }
    
        public void Return_Book(Book book, Books books)
        {
            if (book.Title == books.Title && book.Author == books.Author)
            {
                // Allbooks.Add(book);
                BorrowedBook.Remove(book);
                book.Return_Date = null; 
                books.Available_Quantity +=1;
                if (books.Available_Quantity > books.Quantity)
                {

                    Console.WriteLine("User: AvailableQuantity >Quantity! Verifica stocurile!!!!");
                }
            }
            else { Console.WriteLine("User: ReturnBook :book si books nu coincid!"); }//cout << "In clasa User book si books nu coincid"; }
        }
        // public Book Borrow_Book(Books Books,) { }public void Return_Book(Book book, Books books);
        public void Borrow_Book(Book book, Books books)
        {
            if (book.Title == books.Title && book.Author == books.Author)
            {
                if (books.Available_Quantity > 0)
                {
                    AllBooks.Add(book);
                    Admin admin = new Admin();
                    book.Return_Date = admin.Return_Book_Time(admin.Return_Days);
                    books.Available_Quantity--;
                    BorrowedBook.Add(book);
                   // book.Return_Date=DateTime.Now.AddDays(admin.Return_Days);

                }
                else { Console.WriteLine("User: BorrowBook: Nu se poate imprumut cartea"); }

            }
            else { Console.WriteLine("User: BorrowBook:book si books nu coincid!");

            }
        }
        public void Due_Books(List<IBook> BorrowedBook) {
            foreach (var book in BorrowedBook)
            { if (book.Return_Date < DateTime.Now) { Console.WriteLine("User: Due_Books: Return book" + book.Title + " " + book.Author); }
                Admin admin= new Admin();
                if (book.Return_Date != null) {
                    if (book.Return_Date > DateTime.Now.AddDays(-admin.Due_Days_Notification))
                    { Console.WriteLine("User: Due_Books: Return book in " + admin.Due_Days_Notification + " days: " + book.Title + " " + book.Author); }

                }

            }

        }
    } 
}