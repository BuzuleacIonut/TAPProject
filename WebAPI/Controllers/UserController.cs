//namespace WebAPI.Controllers
    using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
namespace WebAPI.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class UserController : ControllerBase
        {
            private readonly IRepository<IUser> _userService;

            public UserController(IRepository<IUser> userService)
            {
                _userService = userService;
            }


            //[HttpGet]

            [HttpGet("get")]
            public IEnumerable<IUser> Get()
            {
                return _userService.GetAll();
            }

            [HttpPost("add")]
            public ObjectResult Add(IUser user)
        { /*public User(string password, Guid iD, string email, string name, List<IBook> borrowedBook, List<IBook> allbooks)
        {
            Password = password;
            ID = iD;
            Email = email;
            Name = name;
            BorrowedBook = borrowedBook;
            Allbooks = allbooks;
        }*/
            _userService.Add(new User(user.Password, user.Id, user.Email, user.Name, user.BorrowedBook, user.AllBooks));
                _userService.SaveChanges();

                return Ok(" User Added successfully.");
            }

            [HttpPut("update")]
            public ObjectResult Update(Guid id, IUser user)
            {
                var User = _userService.GetById(id);
                if (User == null)
                {
                    return NotFound("user cannot be found.");
                }
                User.Email = user.Email;
                User.Name = user.Name;
                User.Password = user.Password;
            User.Id = user.Id;

                user.BorrowedBook = user.BorrowedBook;
            User.AllBooks = user.AllBooks;

                _userService.Update(user);
                _userService.SaveChanges();
                return Ok("User Updated succesfully.");
            }



            [HttpPut("delete")]
            public ObjectResult Delete(Guid id)
            {
                var user = _userService.GetById(id);
                if (user == null)
                {
                    return NotFound("User cannot be found.");
                }

                _userService.Remove(user);
                _userService.SaveChanges();
                return Ok("User is deleted succesfully.");
            }
        }
    }

