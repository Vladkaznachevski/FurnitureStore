using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ShopCartItem : BaseEntity
    {
        public Product Product { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public string ShopCartId { get; set; }

    }
}
