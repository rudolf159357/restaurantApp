using Microsoft.AspNetCore.Mvc;

namespace restaurantApp.Controllers
{
    public class MenuController : Controller
    {
        // menu view
        public IActionResult Index()
        {
            return View();
        }

        // soup view
        public IActionResult Soup() {
            return View();
        }

        // main  meal view
        public IActionResult Meal() {
            return View();
        }
        // desserts view
        public IActionResult Desserts() {
            return View();
        }
    }
}
