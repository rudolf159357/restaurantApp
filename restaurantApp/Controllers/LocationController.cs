﻿using Microsoft.AspNetCore.Mvc;

namespace restaurantApp.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}