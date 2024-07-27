using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;

namespace PortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDBContext _dBContext;

        public ProjectController(ApplicationDBContext applicatonDBContext)
        {
            _dBContext = applicatonDBContext;
        }
        [HttpGet]
        public async Task<IActionResult> Project()
        {
            var work = await _dBContext.Projects.ToListAsync();
            return View(work);
        }
    }
}

