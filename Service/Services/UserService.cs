using Data.Context;
using Domain;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class  UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetAll1()
        {
            return _repository.GetAll1();
        }
    }
}
