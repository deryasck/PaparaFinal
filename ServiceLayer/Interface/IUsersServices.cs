using DataLayer.Interface;
using DomainLayer.Tablolar;
using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IUsersServices:IService<Invoice>
    {
        List<UserWithInvoiceDto> GetUsers();
        //IQueryable<UserWithInvoiceDto> GetUserInvoices();
    }
}
