using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Spot : BaseEntity
    {
        public int ParkingId { get; set; }
        public virtual Parking Parking { get; set; }
        public int Number { get; set; }
        public bool IsRented { get; set; } = false;
    }
}
