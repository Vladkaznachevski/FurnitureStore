using Data;
using Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ProductSer
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }


        public List<Product> GetProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateProduct(Product Product)
        {
            _repository.Create(Product);
        }

        public void UpdateProduct(Product Product)
        {
            _repository.Update(Product);
        }

        public void DeleteProduct(int id)
        {
            _repository.Delete(id);
        }

    }
}
