using Domain.Entities;
using System;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

    }
}
