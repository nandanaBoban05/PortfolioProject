using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

namespace PortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDBContext _dBContext;

        public ContactController(ApplicationDBContext applicatonDBContext)
        {
            _dBContext = applicatonDBContext;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(Contact viewModel)
        {
            var contact = new Contact
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Message = viewModel.Message

            };
            await _dBContext.Contacts.AddAsync(contact);
            await _dBContext.SaveChangesAsync();

            return View();

        }
    }
}
