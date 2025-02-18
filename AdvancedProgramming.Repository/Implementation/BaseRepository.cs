using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ProductDBEntities _context;
        private readonly DbSet<T> _set;
        public BaseRepository()
        {
            _context = new ProductDBEntities();
            _set = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _set.Add(entity);
            Save();
        }
        public void DeleteById(int id)
        {
            T entityToDelete = _set.Find(id);
            if (entityToDelete != null) 
            { 
                _set.Remove(entityToDelete);
                Save();
            }
        }
        public IEnumerable<T> GetAll()
        {
            return _set.ToList();
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _set.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                Save();
            }
        }
    }
}
