using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class SpaceStation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
