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

        public List<User> GetAll1()
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

    }
}
