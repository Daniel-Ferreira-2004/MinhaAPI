using System.Linq.Expressions;

namespace MinhaAPI.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T? Get(Expression<Func<T, bool>> predicate);
        T add(T entity);
        T update(T entity);
        T delete(T entity);
    }
}
