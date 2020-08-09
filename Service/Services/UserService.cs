using Data.Context;
using Domain;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class  UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<User> GetAll()
        {
            return _repository.SelectAll();
        }

        public User Post(User obj)
        {
            throw new NotImplementedException();
        }

        public User Put(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
