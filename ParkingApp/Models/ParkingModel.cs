using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class ParkingModel : BaseModel
    {
        public int CountryId { get; set; }
        public virtual CountryModel Country { get; set; }
        public int UserId { get; set; }
        public virtual UserModel User { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string Description { get; set; }
        public List<SpotModel> Spots { get; set; }
        public int QuantitySpots { get; set; }
        public string Spot
        {
            get => $"{Spots.Where(x => !x.IsRented).Count()}/{Spots.Count}";
        }
    }
}
