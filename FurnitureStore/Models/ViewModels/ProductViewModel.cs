using Data;
using System.Drawing;
using System.Security.Claims;

namespace FurnitureStore.Models.ViewModels
{
    public class ProductViewModel
    {

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Selected { get; set; }

        public int Selected2 { get; set; }

        public List<Category> Categories { get; set; }
        public List<Manufactory> Manufactories { get; set; }

    }
}
