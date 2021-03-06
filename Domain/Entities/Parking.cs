﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Domain.Entities
{
    public class Parking : BaseEntity
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string Description { get; set; }
        public List<Spot> Spots { get; set; }
    }
}
