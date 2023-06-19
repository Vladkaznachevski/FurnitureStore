using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Product Product)
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
        }

        public void Update(Product Product)
        {
            _context.Products.Update(Product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product Product = Get(id);
            _context.Products.Remove(Product);
            _context.SaveChanges();
        }

    }
}
