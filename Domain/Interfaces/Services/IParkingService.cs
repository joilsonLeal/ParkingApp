using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface IParkingService : IService<Parking>
    {
        public void Save(Parking entity);
    }
}
