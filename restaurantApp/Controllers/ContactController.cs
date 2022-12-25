using Microsoft.AspNetCore.Mvc;

namespace restaurantApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
