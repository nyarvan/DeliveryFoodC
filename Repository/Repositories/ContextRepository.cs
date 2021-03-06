using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataBase;

namespace Repository
{
    public sealed class ContextRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DeliveryContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public ContextRepository(DeliveryContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            //_dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            var entity = _dbSet.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        
        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        
    }
}
