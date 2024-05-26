using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;

namespace WebAPI.Controllers
{

   /* public class BooksController : ControllerBase
    {
        private readonly IBooksService _BooksService;

        public BooksController(IBooksService BooksService) //Ctrl h inlocuieste un text cu altul
        {
            _BooksService = BooksService;
        }/
        [HttpGet]
        public IActionResult Get()
        {
            // var modelCount = _adminService.CountRecords();
            return Ok();
        }*/
        [ApiController]
        [Route("[controller]")]
        public class BooksController : ControllerBase
        { private readonly IRepository<IBooks> _booksService;

            public BooksController(IRepository<IBooks> booksService)
            {
                _booksService = booksService;
            }
            [HttpGet("get")]
            public IEnumerable<IBooks> Get()
            {
                return _booksService.GetAll();
            }

            [HttpPost("add")]
            public ObjectResult Add(IBooks books)
        {  /* 
           public Books(Guid id, string title, string author, Boolean reservation_system, string genre, int quantity, int available_quantity) {
            Id = id;
            Title = title;
            Author = author;
            Rezervation_System= reservation_system;
            Genre = genre;
            Quantity = quantity;
            Available_Quantity = available_quantity;
            Borrowing_Number = borrowing_number; int
        }
      }*/
            _booksService.Add(new Books(books.Id, books.Title, books.Author, books.Rezervation_System, books.Genre, books.Quantity,books.Available_Quantity,books.Borrowing_Number,books.BooksBook));
                _booksService.SaveChanges();

                return Ok(" Books Added successfully.");
            }

            [HttpPut("update")]
            public ObjectResult Update(Guid id, IBooks books)
            {
                var Books = _booksService.GetById(id);
                if (Books == null)
                {
                    return NotFound("Books cannot be found.");
                }
                Books.Id = books.Id;
                Books.Title = books.Title;
                Books.Author = books.Author;
                Books.Genre = books.Genre;
               // Books.Return_Date = books.Return_Date;
                //Book.Books = book.Books;
                Books.Rezervation_System = books.Rezervation_System;
            Books.Quantity= books.Quantity;
            Books.Available_Quantity = books.Available_Quantity;
            Books.Borrowing_Number = books.Borrowing_Number;


            Books.BooksBook= books.BooksBook;
            //public ICollection<IBook> BooksBook { get; set; }



            _booksService.Update(Books);
                _booksService.SaveChanges();
                return Ok("Books Updated succesfully.");
            }



            [HttpPut("delete")]
            public ObjectResult Delete(Guid id)
            {
                var books = _booksService.GetById(id);
                if (books == null)
                {
                    return NotFound("Books cannot be found.");
                }

                _booksService.Remove(books);
                _booksService.SaveChanges();
                return Ok("Books is deleted succesfully.");
            }

        }
    
}

