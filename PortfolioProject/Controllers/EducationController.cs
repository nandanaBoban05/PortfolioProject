﻿using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;

namespace PortfolioProject.Controllers
{
    public class EducationController : Controller
    {
        private readonly ApplicationDBContext _dBContext;

        public EducationController(ApplicationDBContext applicatonDBContext)
        {
            _dBContext = applicatonDBContext;
        }
        public IActionResult Education()
        {
            return View();
        }
    }
}
