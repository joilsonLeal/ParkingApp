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
        private readonly IUserRepository _userRepository;
        public ParkingService(IParkingRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
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
            entity.RegisteredDate = DateTime.Now;
            _repository.Update(entity);
        }

        public void Save(Parking entity, int quantitySpots, string username)
        {
            if (quantitySpots <= 0)
                throw new ArgumentException();
            entity.RegisteredDate = DateTime.Now;
            entity.Spots = new List<Spot>();

            for (int i = 0; i < quantitySpots; i++)
                entity.Spots.Add(new Spot()
                {
                    IsRented = false,
                    Number = i + 1,
                });

            entity.UserId = _userRepository.GetByName(username).Id;

            Post(entity);
        }
    }
}
