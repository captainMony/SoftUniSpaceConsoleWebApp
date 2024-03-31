using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Cargo;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CargoController : Controller
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
