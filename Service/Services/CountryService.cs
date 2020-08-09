using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;
        public CountryService(ICountryRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Country Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<Country> GetAll()
        {
            return _repository.SelectAll();
        }

        public void Post(Country entity)
        {
            _repository.Insert(entity);
        }

        public void Put(Country entity)
        {
            _repository.Update(entity);
        }

        public void Active(int id)
        {
            _repository.Active(id);
        }
    }
}
