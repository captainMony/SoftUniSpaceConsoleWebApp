using Microsoft.AspNetCore.Mvc;

namespace SoftUniSpaceConsoleWebApp.Controllers
{
    public class SpaceStationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
