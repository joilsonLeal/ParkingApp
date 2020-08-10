using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface IUserService : IService<User>
    {
        public void Active(int id);
        public User Login(string username, string password);
        public User GetByName(string username);
    }
}
