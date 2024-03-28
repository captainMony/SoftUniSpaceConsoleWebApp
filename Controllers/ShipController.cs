using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models.Ship;
using SoftUniSpaceConsoleWebApp.Services;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class ShipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        //public IActionResult Get all?


        [HttpPost]
        public IActionResult Create(CreateShipViewModel Ship)
        {
          // public IActionResult Create(CreateCrewViewModel Crew) // ok 2 
          // {
          //     crewService.Add(Crew); //Peak definiton
          //
          //     return RedirectToAction(nameof(Index));
          // }

            shipService.Add


        }
        public IActionResult Delete() 
        {
         return View();
        }

    }
}
