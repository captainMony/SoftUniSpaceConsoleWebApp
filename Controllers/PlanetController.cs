using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using SoftUniSpaceConsoleWebApp.Models.Planet;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class PlanetController : Controller
    {

        private readonly IPlanetService planetService;

        public PlanetController(IPlanetService planetService )  
        {
            this.planetService = planetService;
        }

        public IActionResult Index()
        {
            var planets = planetService.GetAll();
            return View(planets);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePlanetViewModel Planet)
        {
            planetService.Add(Planet);
                return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            planetService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

       
     
    }
}
