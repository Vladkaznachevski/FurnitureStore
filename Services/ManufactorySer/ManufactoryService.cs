using Data;
using Repository.ManufactoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManufactorySer
{
    public class ManufactoryService : IManufactoryService
    {
        private IManufactoryRepository _repository;

        public ManufactoryService(IManufactoryRepository repository)
        {
            _repository = repository;
        }


        public List<Manufactory> GetManufactories()
        {
            return _repository.GetAll();
        }

        public Manufactory GetManufactoryById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateManufactory(Manufactory Manufactory)
        {
            _repository.Create(Manufactory);
        }

        public void UpdateManufactory(Manufactory Manufactory)
        {
            _repository.Update(Manufactory);
        }

        public void DeleteManufactory(int id)
        {
            _repository.Delete(id);
        }

    }
}
