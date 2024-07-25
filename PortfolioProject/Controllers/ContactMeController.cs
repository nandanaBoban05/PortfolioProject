using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class ContactMeController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
