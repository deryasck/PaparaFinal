using DataLayer.Interface;
using DomainLayer.Tablolar;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class DuesServices : IDues
    {
        private readonly IRepository<Dues> _repository;

        public DuesServices(IRepository<Dues> repository)
        {
            _repository = repository;
        }

        public void Add(Dues dues)
        {
            dues.OlusturmaTarihi = System.DateTime.Now;
            dues.Gelis_Tarihi = System.DateTime.Now;
            dues.Odeme_Tarihi=System.DateTime.Now.AddMonths(1);
            _repository.Add(dues);
        }

        public void Delete(Dues dues)
        {
            _repository.Delete(dues);
        }

        public IQueryable<Dues> GetAll()
        {
            return _repository.GetAll();
        }

        public Dues GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateInvoice(Dues dues)
        {
            dues.GuncellmeTarihi = System.DateTime.Now;
            _repository.Update(dues);
        }
    }
}
