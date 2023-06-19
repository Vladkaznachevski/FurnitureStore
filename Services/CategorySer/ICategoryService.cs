using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategorySer
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category Category);
        void UpdateCategory(Category Category);
        void DeleteCategory(int id);
    }

}

