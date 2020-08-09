using Data.Context;
using Domain;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly ParkingAppContext _context;

        public BaseRepository(ParkingAppContext context)
        {
            _context = context;
        }
       
        protected virtual void Delete(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        protected virtual void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        protected virtual T Select(int id)
        {
            return _context.Set<T>().Find(id);
        }

        protected virtual List<T> SelectAll()
        {
            return _context.Set<T>().ToList();
        }

        protected virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }











        void IRepository<T>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Insert(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Select(int id)
        {
            throw new NotImplementedException();
        }

        List<T> IRepository<T>.SelectAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
