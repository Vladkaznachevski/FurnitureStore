using Data;
using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using Services.ProductSer;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FurnitureStore.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly ILogger<HomeController> _logger;
        private IProductService _ProductService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _ProductService = productService;
        }

        public IActionResult Index()
        {
            List<Product> Products = _ProductService.GetProducts();
            return View(Products);
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