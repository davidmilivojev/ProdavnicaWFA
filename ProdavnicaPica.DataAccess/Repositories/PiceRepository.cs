using ProdavnicaPica.DataAccess.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProdavnicaPica.DataAccess.Repositories
{
    public class PiceRepository
    {
        private readonly ProdavnicaPicaContext _context;

        public PiceRepository()
        {
            _context = new ProdavnicaPicaContext();
        }

        public List<Pice> GetAll()
        {
            var data = _context.Pices.ToList();

            return data;
        }

        public Pice GetById(int id)
        {
            var pice = _context.Pices.FirstOrDefault(x => x.ID == id);

            return pice;
        }
        
        public void Update(Pice pice)
        {
            var piceZaIzmenu = _context.Pices.SingleOrDefault(x => x.ID == pice.ID);

            if (piceZaIzmenu == null)
            {
                return;
            }

            _context.Entry(piceZaIzmenu).CurrentValues.SetValues(pice);
            _context.SaveChanges();
        }

        public void Insert(Pice novoPice)
        {
            _context.Pices.Add(novoPice);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var piceZaBrisanje = _context.Pices.SingleOrDefault(x => x.ID == id);

            if (piceZaBrisanje != null)
            {
                _context.Pices.Remove(piceZaBrisanje);
                _context.SaveChanges();
            }
        }
    }
}
