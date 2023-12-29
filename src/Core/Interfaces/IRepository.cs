using System.Linq.Expressions;

namespace Core.Interfaces;

public  interface IRepository<T> where T: class
{
    public Task<IEnumerable<T>> Get(Expression<Func<T, bool>>? filter = null,
     Func<IQueryable<T>, IOrderedEnumerable<T>>? orderBy = null,
      string includeProperties = ""  );

      public  Task<T> GetById( object id);

      public  Task<int> Insert(T entity);

      public Task<int> Update(T entity);

      public Task<int> Delete(T entity);
}