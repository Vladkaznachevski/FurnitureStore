using Data;
using Repository.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategorySer
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }


        public List<Category> GetCategories()
        {
            return _repository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateCategory(Category Category)
        {
            _repository.Create(Category);
        }

        public void UpdateCategory(Category Category)
        {
            _repository.Update(Category);
        }

        public void DeleteCategory(int id)
        {
            _repository.Delete(id);
        }

    }
}
