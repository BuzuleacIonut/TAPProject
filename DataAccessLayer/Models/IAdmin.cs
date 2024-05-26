using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public interface IAdmin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //Admin admin = new Admin();
        //public Admin(Guid Id, string Name, string Email, string Password, int returndays , int duedaysnotifications) {
        // Admin admin = new Admin();
        //  admin.Id = Id;

        //}
        ICollection<IBooks> AllBooks { get; set; } //Books=carti diferite care difera prin titlu si autor
        ICollection<IBook> AllBook { get; set; }// exemplare din Books/ bucati individuale
        ICollection<IUser> AllUsers { get; set; } // List of all the users of the platform
        ICollection<string> Genres { get; set; }// genres of the book
        public int Return_Days { get; set; }// cate zile pentru a returna o carte
        public int Due_Days_Notification { get; set; }
        //public Admin(Guid Id, string Name, string Email, string Password, int returndays, int duedaysnotifications);
        public  DateTime Return_Book_Time(int zile);
    }
}
