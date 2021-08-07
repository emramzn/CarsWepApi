using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiApp.Models;

namespace WepApiApp.FakeData
{
    public static class CreateFakeVehicle
    {

        //Creating fake car data.
        public static List<Vehicle> _vehicles;
        public static List<Vehicle> CreateVehicles()
        {
            string[] vehicleCategories = { "car", "bus", "boat" };
            string[] vehicleColors = { "red", "blue", "black", "white" };
            if (_vehicles == null)
            {
                _vehicles = new Faker<Vehicle>().
                RuleFor(a => a.vehicleId, b => b.IndexFaker).
                RuleFor(a => a.vehicleCategory, b => vehicleCategories[b.Random.Number(2)]).
                RuleFor(a => a.vehicleWheels, b => vehicleCategories[b.Random.Number(2)] == "boat" ? 0 : 4 ).
                RuleFor(a => a.vehicleColor, b => vehicleColors[b.Random.Number(3)]).
                RuleFor(a => a.vehicleHeadlights, b => b.Random.Bool()).Generate(20);

            }
            return _vehicles;
        }

    }
}
