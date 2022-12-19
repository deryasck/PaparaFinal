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
    public class InvoiceService : IInvoice
    {
        private readonly IRepository<Invoice> _repository;

        public InvoiceService(IRepository<Invoice> repository)
        {
            _repository = repository;
        }

        public void Add(Invoice invoice)
        {
            invoice.OlusturmaTarihi = System.DateTime.Now;
            invoice.Son_Odeme_Tarihi=System.DateTime.Now.AddMonths(1);
            _repository.Add(invoice);
        }

        public void Delete(Invoice invoice)
        {
            _repository.Delete(invoice);
        }

        public IQueryable<Invoice> GetAll()
        {
            return _repository.GetAll();
        }

        public Invoice GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void UpdateInvoice(Invoice invoice)
        {

            invoice.GuncellmeTarihi = System.DateTime.Now;
            _repository.Update(invoice);
        }
    }
}
