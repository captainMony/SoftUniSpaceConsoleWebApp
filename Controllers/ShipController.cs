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

        public IActionResult Index()
        {
            return View();
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
        public IActionResult Delete() 
        {
         return View();
        }

    }
}
