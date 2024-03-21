using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class CrewController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create() //tova e definirano v _Layout.cshtml.
        {
            return View(); //posle otiva v views
        }
    }
}
