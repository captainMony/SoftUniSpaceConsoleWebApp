using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CrewController : Controller 

    {
        
        private readonly ICrewService crewService; 


        public CrewController(ICrewService crewService) //!!!
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
            return View(); 
        }

        [HttpPost] // от страницата идва тука затова Views е във <Form><>

        public IActionResult Create(CreateCrewViewModel Crew) // ok 2 
        {
            crewService.Add(Crew); //Peak definiton

            return RedirectToAction(nameof(Index));
        }

         public IActionResult Delete(int id) // From Views/Crew/Index.cshtml 
         {
             crewService.Delete(id); //Step 1 go to Service and call Delete method 

            return RedirectToAction(nameof(Index));
        
         }
    }
}
