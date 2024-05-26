using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dto
{
    public class UserDto
    {
        public string Password { get; set; }
       // public Guid ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public List<IBook> BorrowedBook = new List<IBook>();// books borrowed at the moment
        public List<IBook> Allbooks = new List<IBook>(); //All the borrowed books
       // public void Return_Book(Book book, Books books)
    }
}
