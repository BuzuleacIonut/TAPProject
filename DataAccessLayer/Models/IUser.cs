using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public interface IUser
    {
        public string Password { get; set; }
        public Guid Id{ get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        //piblic  AllBooks
        public ICollection<IBook> BorrowedBook { get; set; } //= new List<IBook>();// books borrowed at the moment
        public ICollection<IBook> AllBooks { get; set; }//= new List<IBook>(); //All the borrowed books
        public void Return_Book(Book book, Books books);
        public void Borrow_Book(Book Book, Books books);

        public void Due_Books(List<IBook> books);
    }
}
