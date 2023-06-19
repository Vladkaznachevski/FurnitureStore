using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManufactorySer
{
    public interface IManufactoryService
    {
        List<Manufactory> GetManufactories();
        Manufactory GetManufactoryById(int id);
        void CreateManufactory(Manufactory Manufactory);
        void UpdateManufactory(Manufactory Manufactory);
        void DeleteManufactory(int id);
    }
}
