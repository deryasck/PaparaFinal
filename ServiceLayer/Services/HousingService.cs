using DataLayer.Interface;
using DomainLayer.Tablolar;
using ServiceLayer.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services
{
    public class HousingService : IHousing

    {
        private readonly IRepository<Housing> _repository;

        public HousingService(IRepository<Housing> repository)
        {
            _repository = repository;
        }

        public IQueryable<Housing> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Housing Housing)
        {
            Housing.OlusturmaTarihi = System.DateTime.Now;
            _repository.Add(Housing);
        }

        public void UpdateHousing(Housing Housing)
        {
            Housing.GuncellmeTarihi = System.DateTime.Now;
            _repository.Update(Housing);
        }

        public void DeleteHousing(Housing housing)
        {
            _repository.Remove(housing);
        }

        public void Delete(Housing housing)
        {
            _repository.Delete(housing);
        }

        public Housing GetHousingById(int id)
        {
            return _repository.GetById(id);
        }

    }
}
