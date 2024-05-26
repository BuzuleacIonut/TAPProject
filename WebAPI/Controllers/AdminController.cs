
//using DataAccessLayerLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;

using DataAccessLayer.Models;
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IRepository<IAdmin > _adminService;

        public AdminController(IRepository<IAdmin> adminService)
        {
            _adminService = adminService;
        }
       

        //[HttpGet]
       
        [HttpGet("get")]
        public IEnumerable<IAdmin > Get()
        {
            return _adminService.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(IAdmin admin)
        { //public Admin(Guid id, string name, string email, string password,
          //List<IBooks> allBooks, List<IBook> allBook, List<IUser> allUsers,Id = id;
          //Name = name;
          // Email = email;
            /// Password = password;
            /// 
           // AllBooks = allBooks ?? new List<IBooks>(); // Initialize with empty list if null
            //AllBook = allBook ?? new List<IBook>(); // Initialize with empty list if null
           // AllUsers = allUsers ?? new List<IUser>(); // Initialize with empty list if null
            //Genres = genres ?? new List<string>(); //

            //Return_Days = returnDays;
            //Due_Days_Notification = dueDaysNotification;
            //List<string> genres, int returnDays, int dueDaysNotification)Return_Days = returnDays;
            // Due_Days_Notification = dueDaysNotification;
            _adminService.Add(new Admin(admin.Id, admin.Name, admin.Email,admin.Password, admin.Return_Days,admin.Due_Days_Notification, admin.AllBooks,admin.AllBook,admin.AllUsers, admin.Genres));
            _adminService.SaveChanges();

            return Ok(" Admin Added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, IAdmin admin)
        {
            var Admin = _adminService.GetById(id);
            if (Admin == null)
            {
                return NotFound("Admin cannot be found.");
            }
            Admin.Email = admin.Email;
            Admin.Name = admin.Name;
            Admin.Password = admin.Password;
            Admin.Return_Days = admin.Return_Days;
            Admin.Due_Days_Notification = admin.    Due_Days_Notification;


            Admin.AllBook=admin.AllBook;
            Admin.AllBooks=admin.AllBooks;
            Admin.Genres=admin.Genres;
            Admin.AllUsers=admin.AllUsers;  

            _adminService.Update(Admin);
            _adminService.SaveChanges();
            return Ok("Admin Updated succesfully.");
        }



        [HttpPut("delete")]
        public ObjectResult Delete(Guid id)
        {
            var admin = _adminService.GetById(id);
            if (admin == null)
            {
                return NotFound("Admin cannot be found.");
            }

            _adminService.Remove(admin);
            _adminService.SaveChanges();
            return Ok("Admin is deleted succesfully.");
        }
        }
    }


