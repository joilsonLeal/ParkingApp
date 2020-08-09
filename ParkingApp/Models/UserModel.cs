using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Models
{
    public class UserModel : BaseNameModel
    {
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int ProfileId { get; set; }
        public ProfileModel Profile { get; set; }
    }
}
