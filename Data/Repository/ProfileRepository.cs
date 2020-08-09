using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ParkingAppContext context) : base(context)
        {

        }

        void IRepository<Profile>.Delete(int id)
        {
            base.Delete(id);
        }

        void IRepository<Profile>.Insert(Profile entity)
        {
            base.Insert(entity);
        }

        Profile IRepository<Profile>.Select(int id)
        {
            return base.Select(id);
        }

        List<Profile> IRepository<Profile>.SelectAll()
        {
            return base.SelectAll();
        }

        void IRepository<Profile>.Update(Profile entity)
        {
            base.Update(entity);
        }
    }
}
