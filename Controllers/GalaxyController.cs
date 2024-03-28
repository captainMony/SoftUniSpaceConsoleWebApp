using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class GalaxyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
