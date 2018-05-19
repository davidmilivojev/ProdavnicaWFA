using ProdavnicaPica.DataAccess.Entities;
using ProdavnicaPica.DataAccess.Repositories;
using System;

namespace ProdavnicaPica.Domain
{
    public class Operacije
    {
        private readonly PiceRepository _piceRepository;
        private readonly OperaterRepository _operaterRepository;
        private readonly ProdajaRepository _prodajaRepository;

        public Operacije()
        {
            _piceRepository = new PiceRepository();
            _prodajaRepository = new ProdajaRepository();
            _operaterRepository = new OperaterRepository();
        }

        public void Prodaja(int piceId, int operaterId)
        {
            var pice = _piceRepository.GetById(piceId);
            pice.Kolicina--;

            _piceRepository.Update(pice);

            Prodaja prodaja = new Prodaja
            {
                OperaterId = operaterId,
                PiceId = piceId,
                Vreme = DateTime.Now
            };
            _prodajaRepository.Insert(prodaja);
        }

        public void UnosPica(int id)
        {
            var pice = _piceRepository.GetById(id);
            pice.Kolicina++;

            _piceRepository.Update(pice);
        }
    }
}
