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


        public CrewController(ICrewService crewService) // i forgot this makes Crewserivee
        {
            this.crewService = crewService;
        }

        public IActionResult Index()
        {
            var crews = crewService.GetAll();

            //  var Crews = CrewEntities
            //      .Select(crew => new CrewViewModel(crew.Id, crew.Name, crew.Age, crew.rank)); // NOTE CREW IS WITH c not C
            // tova e sa service... bruh

            return View(crews);
        }

        public IActionResult Create() //tova e definirano v _Layout.cshtml.
        {
            return View(); //posle otiva v views
        }

        [HttpPost]

        public IActionResult Create(CreateCrewViewModel Crew) // ok 2 //kak podavam danniete e problema??? Age e no@
        {
            crewService.Add(Crew); //ZASHTO NE RA BO TI ??????????????????? TO DO 

            return RedirectToAction(nameof(Index));
        }
    }
}
