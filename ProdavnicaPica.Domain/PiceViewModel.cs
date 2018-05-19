using ProdavnicaPica.DataAccess.Repositories;
using ProdavnicaPica.Domain.Contracts;
using System.Collections.Generic;

namespace ProdavnicaPica.Domain
{
    public class PiceViewModel
    {
        private readonly PiceRepository _piceRepository;

        public PiceViewModel()
        {
            _piceRepository = new PiceRepository();
        }

        public List<PiceModel> GetAll()
        {
            List<PiceModel> result = new List<PiceModel>();
            var data = _piceRepository.GetAll();

            PiceModel model;
            foreach (var item in data)
            {
                model = new PiceModel
                {
                    ID = item.ID,
                    Cena = item.Cena,
                    Kolicina = item.Kolicina,
                    Naziv = item.Naziv
                };
                result.Add(model);
            }

            return result;
        }
    }
}
