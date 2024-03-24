using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CrewController : Controller // REMOVED A 1 FROM CREWCONTROLLER WAS: CrewController1 oops 

    {
        
        private readonly ICrewService crewService; // ok 2


        public CrewController(ICrewService crewService) // i forgot this makes Crewservice
        {
            this.crewService = crewService;
        }

        public IActionResult Index()
        {
            var crews = crewService.GetAll();

            return View(crews); // otizame w view
        }

        public IActionResult Create() //tova e definirano v _Layout.cshtml.
        {
            return View(); //posle otiva v views// da pokaza stranizata s poletata
        }

        [HttpPost]

        public IActionResult Create(CreateCrewViewModel Crew) // ok 2 
        {
            crewService.Add(Crew); //Peak definiton

            return RedirectToAction(nameof(Index));
        }

      //  public IActionResult Delete(id)
      //  {
      //      crewService.Delete(int id);
      //
      //      return RedirectToAction(nameof(Index));
      //
      //  }
    }
}
