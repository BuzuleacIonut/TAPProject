using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Book:IBook
    {   public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
       public  string Genre { get; set; }
       // int Quantity { get; set; }
      public  DateTime ?Return_Date { get; set; }
      public Books Books { get; set; }
      // public ICollection<IBook> BooksBook { get; set; }
        public Book() { }
        public Book(Guid id, string title, string author, string genre, DateTime? returnDate, Books books)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Return_Date = returnDate;
            Books = books;
        }
    }
}
