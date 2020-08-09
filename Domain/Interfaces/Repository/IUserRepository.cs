using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        public void Active(int id);
        public User Login(string username, string password);
    }
}
