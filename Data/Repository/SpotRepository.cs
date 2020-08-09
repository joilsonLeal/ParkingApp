using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class SpotRepository : BaseRepository<Spot>, ISpotRepository
    {
        public SpotRepository(ParkingAppContext context) : base(context)
        {

        }

        void IRepository<Spot>.Delete(int id)
        {
            base.Delete(id);
        }

        void IRepository<Spot>.Insert(Spot entity)
        {
            base.Insert(entity);
        }

        Spot IRepository<Spot>.Select(int id)
        {
            return base.Select(id);
        }

        List<Spot> IRepository<Spot>.SelectAll()
        {
            return base.SelectAll();
        }

        void IRepository<Spot>.Update(Spot entity)
        {
            base.Update(entity);
        }
    }
}
