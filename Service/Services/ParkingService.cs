using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _repository;
        public ParkingService(IParkingRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Parking Get(int id)
        {
            return _repository.Select(id);
        }

        public IList<Parking> GetAll()
        {
            return _repository.SelectAll();
        }

        public void Post(Parking entity)
        {
            _repository.Insert(entity);
        }

        public void Put(Parking entity)
        {
            _repository.Update(entity);
        }
    }
}
