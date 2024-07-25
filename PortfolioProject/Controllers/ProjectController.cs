using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
