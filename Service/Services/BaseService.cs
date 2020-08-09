using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Post(T obj)
        {
            throw new NotImplementedException();
        }

        public T Put(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
