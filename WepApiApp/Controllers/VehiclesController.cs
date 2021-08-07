using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WepApiApp.FakeData;
using WepApiApp.Models;

namespace WepApiApp.Controllers
{

    //For sub process.
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        public List<Vehicle> _NewVehicles = CreateFakeVehicle.CreateVehicles();

        [HttpGet]
        public List<Vehicle> GetVehicles()
        {
            return _NewVehicles;
        }

        [HttpGet("{category}/{color}")]
        public List<Vehicle> GetVehicleByColor(string category, string color)
        {
            return _NewVehicles.Where(a => a.vehicleCategory == category && a.vehicleColor == color).ToList();
        }

        [HttpPost("{id}/{stateHeadlight}")]
        public List<Vehicle> TurnHeadlights(int id, bool stateHeadlight)
        {
            var updateLights = _NewVehicles.FirstOrDefault(a => a.vehicleId == id);
            updateLights.vehicleHeadlights = stateHeadlight;
            return _NewVehicles.Where(a => a.vehicleId == id).ToList();
        }

        [HttpDelete("{id}")]
        public List<Vehicle> VehicleDelete(int id)
        {
            var product = _NewVehicles.FirstOrDefault(a => a.vehicleId == id);
            _NewVehicles.Remove(product);
            return _NewVehicles;
        }
    }
}
