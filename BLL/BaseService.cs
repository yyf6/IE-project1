using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;

namespace BLL
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected IBaseStore<T> baseStore;

        public BaseService(IBaseStore<T> baseStore)
        {
            this.baseStore = baseStore;
        }

        public T Create(T entity)
        {
            return this.baseStore.Create(entity);
        }

        public bool Delete(T entity)
        {
            return this.baseStore.Delete(entity);
        }

        public IQueryable<T> Query(System.Linq.Expressions.Expression<Func<T, bool>> lambda)
        {
            return this.baseStore.Query(lambda);
        }

        public bool Update(T entity)
        {
            return this.baseStore.Update(entity);
        }
    }
}
