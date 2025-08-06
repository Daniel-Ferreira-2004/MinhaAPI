using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using System.Linq.Expressions;

namespace MinhaAPI.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().AsNoTracking().ToList();
        }
        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }
        public T update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
        public T add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T delete(T entity)
        {
           _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        
    }
}
