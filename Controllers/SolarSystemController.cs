using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class SolarSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
