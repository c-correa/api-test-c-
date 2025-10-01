using ApiTest.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Services
{
    public class Service<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public Service(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
