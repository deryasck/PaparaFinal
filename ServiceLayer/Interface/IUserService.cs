using DomainLayer.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IUserService
    {
        public IQueryable<User> GetAll();
        public User GetUserById(int id);
       // public IEnumerable<User> GetUserById(int id);
        public void Add(User User);
        public void UpdateUser(User User);
        public void DeleteUser(User User);
        public void Delete(User user);
    }
}
