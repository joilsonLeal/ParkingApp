using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class ParkingRepository : BaseRepository<Parking>, IParkingRepository
    {
        public ParkingRepository(ParkingAppContext context) : base(context)
        {

        }

        void IRepository<Parking>.Delete(int id)
        {
            base.Delete(id);
        }

        void IRepository<Parking>.Insert(Parking entity)
        {
            base.Insert(entity);
        }

        Parking IRepository<Parking>.Select(int id)
        {
            return base.Select(id);
        }

        List<Parking> IRepository<Parking>.SelectAll()
        {
            return base.SelectAll();
        }

        void IRepository<Parking>.Update(Parking entity)
        {
            base.Update(entity);
        }
    }
}
