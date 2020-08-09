using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class SpotModel : BaseModel
    {
        public int ParkingId { get; set; }
        public int Number { get; set; }
        public bool IsRented { get; set; }
        public decimal Price { get; set; }
    }
}
