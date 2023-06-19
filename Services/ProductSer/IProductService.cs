using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ProductSer
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(int id);
    }
}
