using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Select(int id);
        List<T> SelectAll();
        void Update(T entity);
        void Delete(int id);
        void Insert(T entity);
    }
}
