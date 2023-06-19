using Data;
using FurnitureStore.Models.ViewModels;
using FurnitureStore.Models.ViewModels.Default;
using Microsoft.AspNetCore.Mvc;
using Services.CategorySer;
using Services.ManufactorySer;
using Services.ProductSer;

namespace FurnitureStore.Controllers
{
    public class AdminProductController : Controller
    {


        private IProductService _ProductService;
        private ICategoryService _CategoryService;
        private IManufactoryService _ManufactoryService;


        public AdminProductController(ICategoryService CategoryService, IManufactoryService ManufactoryService,IProductService ProductService)
        {
            _CategoryService = CategoryService;
            _ManufactoryService = ManufactoryService;
            _ProductService = ProductService;

        }


        [HttpGet]
        public IActionResult CreateProduct()
        {

            ProductViewModel model = new ProductViewModel()
            {
                Categories = _CategoryService.GetCategories(),
                Manufactories = _ManufactoryService.GetManufactories(),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel model)
        {

            Product Product = new Product()
            {
                Id = model.Id,
                Price = model.Price,
                Name = model.Name,
                CategoryId = model.Selected,
                ManufactoryId = model.Selected2,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            };

            _ProductService.CreateProduct(Product);

            return RedirectToAction("ProductsList", "AdminProduct");

        }


        public async Task<IActionResult> ProductsList(string search, int? Product, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Product> Products = _ProductService.GetProducts();


            if (!String.IsNullOrEmpty(search))
            {
                Products = Products.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Products = Products.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Products.Count();
            var items = Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ProductListViewModel model = new ProductListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel(Product, search)
                );


            return View(model);
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
