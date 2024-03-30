using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.Galaxy;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class GalaxyController : Controller
    {
        private readonly IGalaxyService galaxyService;

        public GalaxyController(IGalaxyService galaxyService)
        {
            this.galaxyService = galaxyService;
        }

        public IActionResult Index()
        {
            var galaxy = galaxyService.GetAll();
            return View(galaxy);

        }
        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]

        public IActionResult Create(CreateGalaxyViewModel galaxy)
        {
            galaxyService.Add(galaxy);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            galaxyService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
       
    }
}
