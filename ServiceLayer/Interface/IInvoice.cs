using DomainLayer.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IInvoice
    {
        public IQueryable<Invoice> GetAll();
        public Invoice GetById(int id);
        public void Add(Invoice invoice);
        public void UpdateInvoice(Invoice invoice);
        public void Delete(Invoice invoice);
    }
}
