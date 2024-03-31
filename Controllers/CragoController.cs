using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CragoController : Controller
    {

        private readonly ICargoService cargoService;


        public CargoController(ICargoService cargoService) //!!!
        {
            this.cargoService = cargoService;
        }

        public IActionResult Index() //1
        {
            var cargo = cargoService.GetAll();

            return View(cargo); // otizame w view
        }

        public IActionResult Create() //tova e definirano v _Layout.cshtml.
        {
            return View();
        }

        [HttpPost] // от страницата идва тука затова Views е във <Form><>

        public IActionResult Create(CreateCargoViewModel Cargo) // ok 2 
        {
            cargoService.Add(Cargo); //Peak definiton

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) // From Views/Crew/Index.cshtml 
        {
            cargoService.Delete(id); //Step 1 go to Service and call Delete method 

            return RedirectToAction(nameof(Index));

        }
    }
}
