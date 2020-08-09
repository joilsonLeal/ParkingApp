using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IService<T> where T : BaseEntity
    {
        void Post(T entity);

        void Put(T entity);

        void Delete(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
