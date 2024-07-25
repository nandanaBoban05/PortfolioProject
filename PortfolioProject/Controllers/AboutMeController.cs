using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class AboutMeController : Controller
    {
        [ HttpGet]
        public IActionResult About()
        {
            return View();
        }
    }
}
