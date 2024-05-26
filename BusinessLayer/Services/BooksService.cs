using BusinessLayer.Contracts;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class BooksService:IBookService
    {
        private readonly IRepository<Books> _repository;

        public BooksService(IRepository<Books> repository)
        {
            _repository = repository;
        }
    }
}
