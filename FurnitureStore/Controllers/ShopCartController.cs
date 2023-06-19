using Data;
using Microsoft.AspNetCore.Mvc;
using FurnitureStore.Models.ViewModels;
using Repository.ShopCartRepo;
using Services.ProductSer;

namespace FurnitureStore.Controllers
{

    public class ShopCartController : Controller
    {
        private IProductService _ProductService;
        private ShopCartRepository _shopCartRepository;
        public ShopCartController(ShopCartRepository shopCartRepository, IProductService productService)
        {
            _shopCartRepository = shopCartRepository;
            _ProductService = productService;
        }
        public ViewResult Index()
        {
            var items = _shopCartRepository.GetShopItems();
            _shopCartRepository.listShopItems = items;

            var obj = new ShopCartViewModel { ShopCartRepository = _shopCartRepository };

            return View(obj);

        }
        public RedirectToActionResult AddToCart(int id)
        {

            Product item = _ProductService.GetProductById(id);
            _shopCartRepository.AddToCart(item);


            return RedirectToAction("Index");
        }
    }
}
