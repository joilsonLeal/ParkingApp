﻿using Data.Context;
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

        public void Active(int id)
        {
            ActiveDesactive(id, true);
        }

        void IRepository<User>.Delete(int id)
        {
            ActiveDesactive(id, false);
        }

        void IRepository<User>.Insert(User entity)
        {
            base.Insert(entity);
        }

        User IRepository<User>.Select(int id)
        {
            return base.Select(id);
        }

        List<User> IRepository<User>.SelectAll()
        {
            return _context.Users.Include(p => p.Profile).ToList();
        }

        void IRepository<User>.Update(User entity)
        {
            base.Update(entity);
        }

        private void ActiveDesactive(int id, bool status)
        {
            var entity = base.Select(id);
            entity.IsActive = status;
            base.Update(entity);
        }

        public User Login(string username, string password)
        {
            return _context.Users
                    .Include(p => p.Profile)
                    .Where(x => x.Name == username && x.Password == password)
                    .FirstOrDefault();
        }

        public User GetByName(string username)
        {
            return _context.Users.Where(x => x.Name == username).FirstOrDefault();
        }
    }
}
