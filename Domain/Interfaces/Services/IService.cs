using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IService<T> where T : BaseEntity
    {
        void Post(T obj);

        void Put(T obj);

        void Delete(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
