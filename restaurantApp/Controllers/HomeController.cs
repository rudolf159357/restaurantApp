using Microsoft.AspNetCore.Mvc;
using restaurantApp.Models;
using System.Diagnostics;

namespace restaurantApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}