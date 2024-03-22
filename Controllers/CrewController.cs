using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CrewController : Controller // REMOVED A 1 FROM CREWCONTROLLER WAS: CrewController1 oops 

    {
        
        private readonly ICrewService crewService; // ok 2

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create() //tova e definirano v _Layout.cshtml.
        {
            return View(); //posle otiva v views
        }

        [HttpPost]

        public IActionResult Create(CreateCrewViewModel Crew) // ok 2
        {
            crewService.Add(Crew); //ZASHTO NE RA BO TI ??????????????????? TO DO 


            return RedirectToAction(nameof(Index));
        }
    }
}
