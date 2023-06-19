using Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FurnitureStore.Models.ViewModels.Default
{
    public class FilterViewModel
    {
        public FilterViewModel(int? Product , string name)
        {
            SelectedName = name;
            SelectedCloth = Product;
        }
        public int? SelectedCloth { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }
}