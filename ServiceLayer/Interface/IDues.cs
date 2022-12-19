using DomainLayer.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IDues
    {
        public IQueryable<Dues> GetAll();
        public Dues GetById(int id);
        public void Add(Dues dues);
        public void UpdateInvoice(Dues dues);
        public void Delete(Dues dues);
    }
}
