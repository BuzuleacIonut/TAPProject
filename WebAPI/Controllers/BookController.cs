using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Contracts;
using DataAccessLayer.Models;
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {



          private readonly IRepository<IBook> _bookService;

          public BookController(IRepository<IBook> bookService)
          {
              _bookService = bookService;
          }
          [HttpGet("get")]
          public IEnumerable<IBook> Get()
          {
              return _bookService.GetAll();
          }
        
          [HttpPost("add")]
          public ObjectResult Add(IBook book)
          {  /* public Book(Guid id, string title, string author, string genre, DateTime? returnDate, Books books)
      {
          Id = id;
          Title = title;
          Author = author;
          Genre = genre;
          Return_Date = returnDate;
          Books = books;
      }*/
              _bookService.Add(new Book(book.Id, book.Title, book.Author, book.Genre, book.Return_Date, book.Books));
              _bookService.SaveChanges();

              return Ok(" Book Added successfully.");
          }

          [HttpPut("update")]
          public ObjectResult Update(Guid id, IBook book)
          {
              var Book = _bookService.GetById(id);
              if (Book == null)
              {
                  return NotFound("Book cannot be found.");
              }
              Book.Id = book.Id;
              Book.Title = book.Title;
              Book.Author = book.Author;
              Book.Genre = book.Genre;
              Book.Return_Date= book.Return_Date;


            book.Books = book.Books;
            
              //Book.Books = book.Books;


              _bookService.Update(Book);
              _bookService.SaveChanges();
              return Ok("Book Updated succesfully.");
          }



          [HttpPut("delete")]
          public ObjectResult Delete(Guid id)
          {
              var book = _bookService.GetById(id);
              if (book == null)
              {
                  return NotFound("Admin cannot be found.");
              }

              _bookService.Remove(book);
              _bookService.SaveChanges();
              return Ok("Author is deleted succesfully.");
          }

     }

    
}