using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IDAL;

namespace DAL
{
    public class BaseStore<T> : IBaseStore<T>where T : class
    {
        private AQDbContext db = AQFactoryContext.CurrentDbContext();
        public T Create(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
            db.SaveChanges();
            return entity;
        }

        public bool Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
            return true;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> lambda)
        {
            return db.Set<T>().Where(lambda);
        }

        public bool Update(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
