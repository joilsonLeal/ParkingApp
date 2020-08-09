using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repository;
        public ProfileService(IProfileRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Profile Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<Profile> GetAll()
        {
            return _repository.SelectAll();
        }

        public void Post(Profile entity)
        {
            _repository.Insert(entity);
        }

        public void Put(Profile entity)
        {
            _repository.Update(entity);
        }
    }
}
