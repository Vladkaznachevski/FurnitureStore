using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CategoryRepo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Category Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
        }

        public void Update(Category Category)
        {
            _context.Categories.Update(Category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category Category = Get(id);
            _context.Categories.Remove(Category);
            _context.SaveChanges();
        }

    }
}
