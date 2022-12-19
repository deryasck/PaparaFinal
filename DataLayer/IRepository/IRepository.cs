using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IRepository<T> where T : class
    {
        // T GetById(int id);
        //IQueryable<T> GetById(int id);
        T GetById(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Delete(T entity);
    }
}
