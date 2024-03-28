using Microsoft.AspNetCore.Mvc;

using SoftUniSpaceConsoleWebApp.Models.Ship;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class ShipController : Controller
    {
        private readonly IShipService shipService;

        public ShipController(IShipService shipService)
        {
            this.shipService = shipService;
        }

        public IActionResult Index() //1 
        {
            var ships = shipService.GetAll();

            return View(ships); // otizame w view
        }

        public IActionResult Create()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Create(CreateShipViewModel Ship)
        {
    

            shipService.Add(Ship);

            return RedirectToAction(nameof(Index));


        }
        public IActionResult Delete(int id) 
        {
            shipService.Delete(id); //Step 1 go to Service and call Delete method 

            return RedirectToAction(nameof(Index));
        }

    }
}
