using Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class User : BaseEntityName
    {
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public Domain.Entities.Profile Profile { get; set; }

    }
}
