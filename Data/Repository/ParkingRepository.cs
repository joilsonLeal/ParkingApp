using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _context.Parkings
                        .Include(c => c.Country)
                        .Include(s => s.Spots)
                        .Include(u => u.User)
                        .SingleOrDefault(x => x.Id == id);
        }

        List<Parking> IRepository<Parking>.SelectAll()
        {
            return _context.Parkings
                        .Include(c => c.Country)
                        .Include(u => u.User)
                        .Include(s => s.Spots)
                        .Where(x=> x.User.IsActive)
                        .ToList();
        }

        void IRepository<Parking>.Update(Parking entity)
        {
            base.Update(entity);
            _context.Spots.UpdateRange(entity.Spots);
            _context.SaveChanges();
        }
    }
}
