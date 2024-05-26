using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public interface IBooks
    { // properties
        public ICollection<IBook> BooksBook { get; set; }
        public Guid Id { get; set; }
       public string Title { get; set; }
       string Author { get; set; }
       Boolean Rezervation_System { get; set; }
       string Genre { get; set; }
        int Quantity { get; set; }
        int Borrowing_Number { get; set; }
        int Available_Quantity { get; set; }
       //public DateTime Return_Date { get; set; }
        // methods
        public  void AddBooks() { }
        
    }
}
