using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(ParkingAppContext context) : base(context)
        {

        }

        void IRepository<Country>.Delete(int id)
        {
            ActiveDesactive(id, false);
        }

        void IRepository<Country>.Insert(Country entity)
        {
            base.Insert(entity);
        }

        Country IRepository<Country>.Select(int id)
        {
            return base.Select(id);
        }

        List<Country> IRepository<Country>.SelectAll()
        {
            return _context.Countries.Where(x => x.IsActive == true).ToList();
        }

        void IRepository<Country>.Update(Country entity)
        {
            base.Update(entity);
        }

        private void ActiveDesactive(int id, bool status)
        {
            var entity = base.Select(id);
            entity.IsActive = status;
            base.Update(entity);
        }

        void ICountryRepository.Active(int id)
        {
            ActiveDesactive(id, true);
        }
    }
}
