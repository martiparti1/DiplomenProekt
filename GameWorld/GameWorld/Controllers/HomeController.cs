using GameWorld.Data;
using GameWorld.Models;
using GameWorld.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var randomProducts = _context.Products
        .OrderBy(x => Guid.NewGuid())
        .Take(4)
        .ToList();

            var productIndexVMs = randomProducts
                .Select(x => new ProductIndexVM
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    Description = x.Description,
                    Image = x.Image,
                    Price = x.Price
                })
                .ToList();

            return View(productIndexVMs);
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
