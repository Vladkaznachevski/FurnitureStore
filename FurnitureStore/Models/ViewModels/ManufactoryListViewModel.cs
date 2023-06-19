using Data;
using FurnitureStore.Models.ViewModels.Default;

namespace FurnitureStore.Models.ViewModels
{
    public class ManufactoryListViewModel
    {
        public List<Manufactory> Manufactories { get; }
        public PageViewModel PageViewModel { get; }
        public SortViewModel SortViewModel { get; }
        public FilterViewModel FilterViewModel { get; }

        public ManufactoryListViewModel
        (
            List<Manufactory> manufactories,
            PageViewModel pageViewModel,
            SortViewModel sortViewModel,
            FilterViewModel filterViewModel
        )
        {
            Manufactories = manufactories;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}

