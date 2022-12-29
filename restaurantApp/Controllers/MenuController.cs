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
        public async Task<IActionResult> SoupProduct(int? id)
        {
            if (id == null) {
                return NotFound();
            }

            var value = await Context.Soups.FindAsync(id);

            return View(value);
        }

        [Route("[controller]/soup/product/success")]
        public async Task<IActionResult> SoupThank(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = await Context.Soups.FindAsync(id);

            return View(value);
        }

        // main  meal view
        [Route("[controller]/meal")]
        public async Task<IActionResult> Meal() {
            return View(await Context.Meals.ToListAsync());
        }

        [Route("[controller]/meal/product")]
        public async Task<IActionResult> MealProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = await Context.Meals.FindAsync(id);

            return View(value);
        }

        [Route("[controller]/meal/product/success")]
        public async Task<IActionResult> MealThank(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = await Context.Meals.FindAsync(id);

            return View(value);
        }

        // desserts view
        [Route("[controller]/desserts")]
        public async Task<IActionResult> Desserts() {
            return View(await Context.Desserts.ToListAsync());
        }

        [Route("[controller]/desserts/product")]
        public async Task<IActionResult> DessertProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = await Context.Desserts.FindAsync(id);

            return View(value);
        }

        [Route("[controller]/desserts/product/success")]
        public async Task<IActionResult> DessertThank(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var value = await Context.Desserts.FindAsync(id);

            return View(value);
        }
    }
}
