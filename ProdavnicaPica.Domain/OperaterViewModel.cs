using ProdavnicaPica.DataAccess.Repositories;
using ProdavnicaPica.Domain.Contracts;
using System.Collections.Generic;

namespace ProdavnicaPica.Domain
{
    public class OperaterViewModel
    {
        private readonly OperaterRepository _operaterRepository;

        public OperaterViewModel()
        {
            _operaterRepository = new OperaterRepository();
        }

        public List<OperatorModel> GetAll()
        {
            List<OperatorModel> result = new List<OperatorModel>();
            var data = _operaterRepository.GetAll();

            OperatorModel model;
            foreach (var item in data)
            {
                model = new OperatorModel
                {
                    Id = item.ID,
                    Ime=item.Ime
                };
                result.Add(model);
            }

            return result;
        }
    }
}
