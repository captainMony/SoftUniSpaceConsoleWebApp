using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CragoController : Controller
    {

        private readonly ICargoService cargoService;


        public CargoController(ICargoService cargoService)
        {
            this.cargoService = cargoService;
        }

        public IActionResult Index() 
        {
            var cargo = cargoService.GetAll();

            return View(cargo); 
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost] 

        public IActionResult Create(CreateCargoViewModel Cargo) 
        {
            cargoService.Add(Cargo); 

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            cargoService.Delete(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
