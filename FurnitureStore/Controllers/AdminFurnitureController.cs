using Data;
using FurnitureStore.Models.ViewModels.Default;
using Microsoft.AspNetCore.Mvc;
using FurnitureStore.Models.ViewModels;
using Services;
using Services.CategorySer;
using Services.ManufactorySer;


namespace Molina.Controllers
{
    public class AdminFurnitureController : Controller
    {


        private ICategoryService _CategoryService;
        private IManufactoryService _ManufactoryService;
     

        public AdminFurnitureController(ICategoryService CategoryService, IManufactoryService ManufactoryService)
        {
            _CategoryService = CategoryService;
            _ManufactoryService = ManufactoryService;
        
        }


        [HttpGet]
        public IActionResult CreateCategory()
        {
            Category model = new Category();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category model)
        {
            if (ModelState.IsValid)
            {

                Category Category = new Category()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                    };

                    _CategoryService.CreateCategory(Category);

            }
            return View(model);
        }


        [HttpGet]
        public IActionResult CreateManufactory()
        {
            Manufactory model = new Manufactory();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateManufactory(Manufactory model)
        {
            if (ModelState.IsValid)
            {
                Manufactory Manufactory = new Manufactory()
                {
                    Id = model.Id,
                    Name = model.Name,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };
                _ManufactoryService.CreateManufactory(Manufactory);

            }
            return View(model);
        }




        public async Task<IActionResult> CategoriesList(string search, int? Category, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Category> Categories = _CategoryService.GetCategories();


            if (!String.IsNullOrEmpty(search))
            {
                Categories = Categories.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Categories = Categories.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Categories.Count();
            var items = Categories.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            CategoryListViewModel model = new CategoryListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel(Category, search)
                );


            return View(model);
        }


        public async Task<IActionResult> ManufactoriesList(string search, int? Manufactory, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Manufactory> Manufactories = _ManufactoryService.GetManufactories();


            if (!String.IsNullOrEmpty(search))
            {
                Manufactories = Manufactories.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Manufactories = Manufactories.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Manufactories.Count();
            var items = Manufactories.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ManufactoryListViewModel model = new ManufactoryListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel(Manufactory, search)
                );


            return View(model);
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
