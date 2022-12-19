using DataLayer.Contex;
using DataLayer.IRepository;
using DomainLayer.Tablolar;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class UserRepository : Repository<Invoice>, IUserRepository
    {
        public UserRepository(SiteAppDbContext context) : base(context)
        {
        }

        public List<Invoice> GetUserInvoices()
        {
           // Invoice datasını çekerken User datasınıda alınmasını sağladık(Eager Loading)
            return _context.Invoices.Include(x => x.User).ToList();
        }


    }
}
