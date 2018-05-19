using ProdavnicaPica.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaPica.DataAccess.Repositories
{
    public class OperaterRepository
    {
        private readonly ProdavnicaPicaContext _context;
        public OperaterRepository()
        {
            _context = new ProdavnicaPicaContext();
        }
        public List<Operater> GetAll()
        {
            var data = _context.Operaters.ToList();
            return data;

        }

        public Operater GetById(int id)
        {
            var operater = _context.Operaters.FirstOrDefault(x => x.ID == id);

            return operater;
        }

        public void Update(Operater operater)
        {
            var operaterIzmena = _context.Operaters.SingleOrDefault(x => x.ID == operater.ID);
            if (operaterIzmena == null)
            {
                return;
            }
            _context.Entry(operaterIzmena).CurrentValues.SetValues(operater);
            _context.SaveChanges();
        }

        public void Insert(Operater noviOperater)
        {
            _context.Operaters.Add(noviOperater);
            _context.SaveChanges();

        }
        
        public void Delete(int id)
        {
            var operaterBrisanje = _context.Operaters.SingleOrDefault(x => x.ID == id);
            if (operaterBrisanje != null)
            {
                _context.Operaters.Remove(operaterBrisanje);
                _context.SaveChanges();
            }
        }
    }
}
