using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;

namespace TUIBackEnd.DLL.Common
{
  

    public interface IGenericRepository<T, TKey>
       where T : Entity<TKey>
       where TKey : IComparable<TKey>
    {

        IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
        T GetById(TKey id);
        void RunTransaction(Action action);
        int Count();
        int Count(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }

}
