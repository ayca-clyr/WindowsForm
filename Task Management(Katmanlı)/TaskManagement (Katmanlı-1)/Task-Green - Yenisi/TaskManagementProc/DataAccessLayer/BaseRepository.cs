using DataAccessLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        TaskManagemenetContext _context;

        internal BaseRepository(TaskManagemenetContext context)
        {
            _context = context;
        }
        public void Add(TEntity item)
        {
            _context.Entry<TEntity>(item).State = EntityState.Added;
        }

        public void Remove(TEntity item)
        {
            _context.Entry<TEntity>(item).State = EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _context.Entry<TEntity>(item).State = EntityState.Modified;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

   
    }


}
