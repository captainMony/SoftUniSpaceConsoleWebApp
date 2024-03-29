using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.SolarSystem;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class SolarSystemController : Controller
    {

        private readonly ISolarSystemService solarSystemService;

        public SolarSystemController(ISolarSystemService solarSystemService)
        {
            this.solarSystemService = solarSystemService;
        }

        public IActionResult Index() //1 
        {
            var system = solarSystemService.GetAll();

            return View(system); // otizame w view
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CreateSolarSystemViewModel System)
        {


            solarSystemService.Add(System);

            return RedirectToAction(nameof(Index));


        }
        public IActionResult Delete(int id)
        {
            solarSystemService.Delete(id); //Step 1 go to Service and call Delete method 

            return RedirectToAction(nameof(Index));
        }



    }
}
