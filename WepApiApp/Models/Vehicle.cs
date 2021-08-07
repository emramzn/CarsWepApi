using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiApp.Models
{
    public class Vehicle
    {

        public int vehicleId { get; set; }
        public string vehicleCategory { get; set; }
        public string vehicleColor { get; set; }
        public int vehicleWheels { get; set; }
        public bool vehicleHeadlights { get; set; }

    }
}
