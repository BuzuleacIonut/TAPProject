using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Books : IBooks
    { public Guid Id { get; set; }
        public ICollection<IBook> BooksBook { get; set; }
       public  string Title{ get; set; }
        public string Author { get; set; }
       public  Boolean Rezervation_System { get; set; }
       public string Genre { get; set; }
       public  int Quantity { get; set; }
       public int Available_Quantity { get; set; } 
        public string ?Description { get; set; } 
        public int Borrowing_Number { get; set; }
      // public ICollection<IBook> BooksBook { get; set; }
       public void AddBooks(string Title, string Author, bool Reservation_System, string Genre, int Quantity, int available) {
            Books books = new Books();
            books.Title = Title; ;
            books.Author = Author;
            books.Rezervation_System = Reservation_System;
            books.Genre= Genre;
            books.Quantity = Quantity;
            books.Available_Quantity = available;

        }
        public Books() { }

        public Books(Guid id, string title, string author, Boolean reservation_system, string genre, int quantity, int available_quantity,int borrowing_number, ICollection<IBook> booksbook) {
            Id = id;
            Title = title;
            Author = author;
            Rezervation_System= reservation_system;
            Genre = genre;
            Quantity = quantity;
            Available_Quantity = available_quantity;
            Borrowing_Number = borrowing_number;
            BooksBook = booksbook;
        }

       // public List
        //public Book(bool isAvailable)
    
        //IsAvailable = isAvailable;
    

   
    }
}
