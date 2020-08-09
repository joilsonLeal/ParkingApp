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

        public User Login(string username, string password)
        {
            return _repository.Login(username, password);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public User Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<User> GetAll()
        {
            return _repository.SelectAll();
        }

        public void Post(User entity)
        {
            _repository.Insert(entity);
        }

        public void Put(User entity)
        {
            _repository.Update(entity);
        }

        public void Active(int id)
        {
            _repository.Active(id);
        }

    }
}
