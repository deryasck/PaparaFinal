using DataLayer.Interface;
using DomainLayer.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IUserRepository:IRepository<Invoice>
    {
        List<Invoice> GetUserInvoices();
        //IQueryable<Invoice> GetUserInvoices();
    }
}
