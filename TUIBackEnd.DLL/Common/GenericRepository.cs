using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;

using System.Data.Entity;



namespace TUIBackEnd.DLL.Common
{
    public abstract class GenericRepository<T, TK> : IGenericRepository<T, TK>
      where T : Entity<TK>
       where TK : IComparable<TK>
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).AsQueryable();
        }

        public int Count()
        {
            return _dbset.Count();
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbset.Count(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.AsQueryable();
        }


        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return GetAll(predicate);
        }

        public T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;

        }

        public T GetById(TK id)
        {
            return _dbset.SingleOrDefault(x => x.Id.CompareTo(id) == 0);
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }


        public void RunTransaction(Action action)
        {
            using (var dbContextTransaction = _entities.Database.BeginTransaction())
            {
                try
                {
                    action();

                    dbContextTransaction.Commit();
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    throw;
                }
            }
        }
    }
}
