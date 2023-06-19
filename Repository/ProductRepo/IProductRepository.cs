using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProductRepo
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
