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
    public class AdminService : IAdminService

    {
        private readonly IRepository<Admin> _repository;

        public AdminService(IRepository<Admin> repository)
        {
            _repository = repository;
        }
    }
}
