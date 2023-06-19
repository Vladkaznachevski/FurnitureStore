using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ManufactoryRepo
{
    public class ManufactoryRepository : IManufactoryRepository
    {
        private readonly ApplicationContext _context;

        public ManufactoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Manufactory> GetAll()
        {
            return _context.Manufactories.ToList();
        }

        public Manufactory Get(int id)
        {
            return _context.Manufactories.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Manufactory Manufactory)
        {
            _context.Manufactories.Add(Manufactory);
            _context.SaveChanges();
        }

        public void Update(Manufactory Manufactory)
        {
            _context.Manufactories.Update(Manufactory);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Manufactory Manufactory = Get(id);
            _context.Manufactories.Remove(Manufactory);
            _context.SaveChanges();
        }
    }
}
