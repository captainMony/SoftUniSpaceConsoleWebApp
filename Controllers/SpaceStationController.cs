using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.SpaceStation;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class SpaceStationController : Controller
    {
        private readonly ISpaceStationService spaceStationService;

        public SpaceStationController(ISpaceStationService spaceStationService)
        {
            this.spaceStationService = spaceStationService;
        }

        public IActionResult Index()
        {
            var spacespacestation = spaceStationService.GetAll();

            return View(spacespacestation);

        }
        
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(CreateSpaceStationViewModel STATION)
        {
            spaceStationService.Add(STATION);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            spaceStationService.Delete(id);
                return RedirectToAction(nameof(Index));
        }

    }
}
