﻿using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
