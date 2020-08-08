using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Domain.Entities
{
    public class Parking
    {
        public int ParkingId { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
    }
}
