using System.Diagnostics.Eventing.Reader;
using ApiTest.Data;
using ApiTest.Utils;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Services
{
    public class Service<T> where T : class, IBaseEntity
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

        public T? GetById(int id)
        {
            T? record = _entities.FirstOrDefault(x => x.Id == id);
            if (record == null)
            {
                throw new ArgumentException("No hat data");
            }
            return record;
        }

        public OkResult Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
            return new OkResult {Ok = true};
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
