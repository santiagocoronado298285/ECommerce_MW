using ECommerce_MW.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataBaseContext _context;

        public CategoriesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Countries  
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
