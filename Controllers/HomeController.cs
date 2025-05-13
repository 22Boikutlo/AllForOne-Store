using System.Diagnostics;
using AllForOne_Store.Data;
using AllForOne_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllForOne_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: Home/Index
        public async Task<IActionResult> Index()
        {
            // Fetch some products to feature (e.g., the first 4 products or any custom selection)
            var featuredProducts = await _context.Products
                .Take(4)  // You can adjust the number or criteria as needed
                .ToListAsync();

            return View(featuredProducts);  // Pass them to the view
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
