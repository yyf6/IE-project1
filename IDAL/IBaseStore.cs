using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace IDAL
{
    public interface IBaseStore<T>
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>添加后的数据实体</returns>
        T Create(T entity);


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);


        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否删除成功</returns>
        bool Delete(T entity);


        /// <summary>
        /// 根据lambda表达式查询数据
        /// </summary>
        /// <param name="lambda">lambda表达式</param>
        /// <returns>查询后的结果实体</returns>
        IQueryable<T> Query(Expression<Func<T, bool>> lambda);
    }
}
