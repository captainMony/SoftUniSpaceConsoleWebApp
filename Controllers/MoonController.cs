using Microsoft.AspNetCore.Mvc;
using SoftUniSpaceConsoleWebApp.Models.Moon;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;


namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class MoonController : Controller
    {
        private readonly IMoonService MoonService;

        public MoonController(IMoonService moonService)
        {
            MoonService = moonService;
        }

        public IActionResult Index()
        {
            var moon = MoonService.GetAll();
            return View(moon);
             
        }
        public IActionResult Create()
        {
            return View();
        }
            [HttpPost]
            public IActionResult Create(CreateMoonViewModel Moon)
            {
            MoonService.Add(Moon);
            return RedirectToAction(nameof(Index)); 
            }
          public IActionResult Delete(int id)
        {
            MoonService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
       
















    }
        
}