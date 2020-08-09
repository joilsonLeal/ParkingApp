using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class ParkingViewModel
    {
        public ParkingModel Parking { get; set; }
        public List<CountryModel> Countries { get; set; }
    }
}
