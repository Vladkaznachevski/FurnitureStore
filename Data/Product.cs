using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ManufactoryId { get; set; }
        public Manufactory Manufactory { get; set; }

    }
}
