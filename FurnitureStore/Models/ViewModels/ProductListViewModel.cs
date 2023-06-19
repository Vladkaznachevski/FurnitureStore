using Data;
using FurnitureStore.Models.ViewModels.Default;

namespace FurnitureStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public ProductListViewModel
        (
            List<Product> products,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Products = products;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}

