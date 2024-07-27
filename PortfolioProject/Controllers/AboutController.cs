using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;

namespace PortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDBContext _dBContext;

        public AboutController(ApplicationDBContext applicatonDBContext)
        {
            _dBContext = applicatonDBContext;
        }
        [ HttpGet]
        public IActionResult AboutIndex()
        {
            return View();
        }
    }
}
