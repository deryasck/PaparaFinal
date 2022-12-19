using DataLayer.Contex;
using DataLayer.Interface;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly SiteAppDbContext _context;

        public Repository(SiteAppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            
        }

        public void Delete(T entity)
        {
            T model = _context.Set<T>().Find(entity);
            if (model is not null)
            {
                //model.IsDeleted = true;
                _context.Entry(model).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            var modal = _context.Set<T>().Find(entity);
            if (modal != null)
            {
                _context.Entry(modal).State = EntityState.Detached;
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }

        }

        public void Update(T entity)
        {
            //T model = _context.Set<T>().Find(entity.ID);
            //if (model != null)
            //{
            //    _context.Entry(entity).State = EntityState.Modified;
            //    _context.SaveChanges();
            //}
            _context.Update(entity);
            _context.SaveChanges();

        }

        //IQueryable<T> IRepository<T>.GetById(int id)
        //{
        //    return _context.Set<T>().Where(x => x.ID == id).AsQueryable();
        //}

    }
}
