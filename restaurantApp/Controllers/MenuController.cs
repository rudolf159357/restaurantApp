using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restaurantApp.Data;

namespace restaurantApp.Controllers
{
    public class MenuController : Controller
    {

        public AppDbContext Context { get; set; }

        public MenuController(AppDbContext context)
        {
            Context = context;
        }

        // menu view
        public IActionResult Index()
        {
            return View();
        }

        // soup view
        [Route("[controller]/soup")]
        public async Task<IActionResult> Soup() {
            return View(await Context.Soups.ToListAsync());
        }

        [Route("[controller]/soup/product")]
        public IActionResult SoupProduct(int? id)
        {
            if (id == null) {
                return NotFound();
            }

            var value = Context.Soups.Find(id);

            return View(value);
        }

        [Route("[controller]/soup/product/success")]
        public IActionResult SoupThank(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = Context.Soups.Find(id);

            return View(value);
        }

        // main  meal view
        public IActionResult Meal() {
            return View();
        }
        // desserts view
        public IActionResult Desserts() {
            return View();
        }

        public IActionResult Product() {
            return View();
        }
    }
}
