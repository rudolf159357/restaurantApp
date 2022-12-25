using Microsoft.AspNetCore.Mvc;

namespace restaurantApp.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
