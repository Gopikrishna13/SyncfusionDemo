using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SyncfusionDemo.Models;

namespace SyncfusionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<object>
            {
                new { productId = 1, productName = "Laptop", price = 1200.99 },
                new { productId = 2, productName = "TV", price = 1300.00 },
                new { productId = 3, productName = "Radio", price = 1100.99 }
            };
            Console.WriteLine($"Data Count: {products.Count}");

            ViewBag.DataSource = products;

            return View();
        }

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
