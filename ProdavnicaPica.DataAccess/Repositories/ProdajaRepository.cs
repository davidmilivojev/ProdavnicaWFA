using ProdavnicaPica.DataAccess.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProdavnicaPica.DataAccess.Repositories
{
    public class ProdajaRepository
    {
        private readonly ProdavnicaPicaContext _context;

        public ProdajaRepository()
        {
            _context = new ProdavnicaPicaContext();
        }

        public List<Prodaja> GetAll()
        {
            var data = _context.Prodajas.ToList();

            return data;
        }

        public Prodaja GetById(int id)
        {
            var prodaja = _context.Prodajas.FirstOrDefault(x => x.ID == id);

            return prodaja;
        }

        public void Update(Prodaja prodaja)
        {
            var prodajaZaIzmenu = _context.Prodajas.SingleOrDefault(x => x.ID == prodaja.ID);

            if (prodajaZaIzmenu == null)
            {
                return;
            }

            _context.Entry(prodajaZaIzmenu).CurrentValues.SetValues(prodaja);
            _context.SaveChanges();
        }

        public void Insert(Prodaja novaProdaja)
        {
            _context.Prodajas.Add(novaProdaja);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var prodajaZaBrisanje = _context.Prodajas.SingleOrDefault(x => x.ID == id);

            if (prodajaZaBrisanje != null)
            {
                _context.Prodajas.Remove(prodajaZaBrisanje);
                _context.SaveChanges();
            }
        }
    }
}
