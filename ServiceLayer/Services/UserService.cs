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
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void Add(User User)
        {
            
            User.OlusturmaTarihi = System.DateTime.Now;
            _repository.Add(User);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public void DeleteUser(User User)
        {
            _repository.Delete(User);
        }

        public IQueryable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateUser(User User)
        {

            User.GuncellmeTarihi = System.DateTime.Now;
            _repository.Update(User);
        }

    }
}
