using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class SpotService : ISpotService
    {
        private readonly ISpotRepository _repository;
        public SpotService(ISpotRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Spot Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<Spot> GetAll()
        {
            return _repository.SelectAll();
        }

        public void Post(Spot entity)
        {
            _repository.Insert(entity);
        }

        public void Put(Spot entity)
        {
            _repository.Update(entity);
        }
    }
}
