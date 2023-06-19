using Data;
using FurnitureStore.Models.ViewModels.Default;

namespace FurnitureStore.Models.ViewModels
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public CategoryListViewModel
        (
            List<Category> categories,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Categories = categories;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}

