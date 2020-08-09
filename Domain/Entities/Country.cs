using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Country : BaseEntityName 
    {
        public bool IsActive { get; set; } = true;
    }
}
