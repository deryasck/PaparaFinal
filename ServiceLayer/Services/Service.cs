using DataLayer.Contex;
using DataLayer.Interface;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly SiteAppDbContext _siteAppDbContext;

        public Service(IRepository<T> repository, SiteAppDbContext siteAppDbContext)
        {
            _repository = repository;
            _siteAppDbContext = siteAppDbContext;
        }

        public void Add(T entity)
        {
           _repository.Add(entity);
           _siteAppDbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
          
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
