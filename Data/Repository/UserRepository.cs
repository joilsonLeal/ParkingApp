using Data.Context;
using Domain;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ParkingAppContext context) : base(context)
        {

        }

        void IRepository<User>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Insert(User entity)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Select(int id)
        {
            return base.Select(id);
        }

        List<User> IRepository<User>.SelectAll()
        {
            try
            {
                var a = _context.Users.Include(p => p.Profile).Where(x => x.IsActive == false).ToList();
                return a;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        void IRepository<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
