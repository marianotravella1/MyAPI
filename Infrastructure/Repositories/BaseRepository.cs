using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> where T : class
    {
        private readonly DbContext _context;
        public BaseRepository(DbContext context) { _context = context; }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }
        public T? Get<TId>(TId id)
        {
            return _context.Set<T>().Find(new object[] { id });
        }
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
