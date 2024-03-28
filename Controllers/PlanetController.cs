using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class PlanetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
