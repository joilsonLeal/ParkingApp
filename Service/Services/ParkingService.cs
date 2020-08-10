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
        private readonly ISpotRepository _spotRepository;
        public ParkingService(IParkingRepository repository, ISpotRepository spotRepository)
        {
            _repository = repository;
            _spotRepository = spotRepository;
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

        public void Save(Parking entity)
        {
            entity.RegisteredDate = DateTime.Now;
            if(entity.Id > 0)
            {
                Put(entity);
            }
            else
            {
                Post(entity);
            }
        }
    }
}
