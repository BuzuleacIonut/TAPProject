using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Admin:IAdmin
    {   public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //Admin admin = new Admin();
        //public Admin(Guid Id, string Name, string Email, string Password, int returndays , int duedaysnotifications) {
           // Admin admin = new Admin();
          //  admin.Id = Id;
        
        //}
        public ICollection<IBooks> AllBooks { get; set; } //Books=carti diferite care difera prin titlu si autor
       public  ICollection<IBook> AllBook { get; set; }// exemplare din Books/ bucati individuale
       public  ICollection<IUser> AllUsers { get; set; } // List of all the users of the platform
       public ICollection<string> Genres { get; set; }// genres of the book
        //List<>
        public int Return_Days { get; set; }// cate zile pentru a returna o carte
        public int Due_Days_Notification { get; set; }//cu cate zile inainte primeste notificarea despre returnarea cartilor
        public Admin(Guid id, string name, string email, string password, int returnDays, int dueDaysNotification, ICollection<IBooks> allBooks, ICollection<IBook> allBook, ICollection<IUser> allUsers,ICollection<string > genres)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
           
            Return_Days = returnDays;
            Due_Days_Notification = dueDaysNotification;
            AllBooks = allBooks;//?? new ICollection<IBooks>(); // Initialize with empty list if null
            AllBook = allBook;//?? new List<IBook>(); // Initialize with empty list if null
            AllUsers = allUsers;//?? new List<IUser>(); // Initialize with empty list if null
            Genres = genres;//?? new List<string>(); //
        }
        public Admin() { 
        
        }
        public DateTime Return_Book_Time(int Return_Days) { return DateTime.Now.AddDays(Return_Days); }
    }
}
