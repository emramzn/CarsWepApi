using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WepApiApp.Controllers;
using WepApiApp.Models;

namespace WepApiApp.Controllers
{
    //For Select all Vehicles.
    [Route("api/[controller]")]
    public class AllVehiclesController : Controller
    {
        VehiclesController createdVehicles = new VehiclesController();
        public List<Vehicle> GetAllVehicles()
        {
            return createdVehicles._NewVehicles;  
        }
    }
}
