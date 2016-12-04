using SEP.Contract.Repositories;
using SEP.Model.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SEP.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel, new()
    {
        protected readonly  DbContext _context;
        protected readonly IDbSet<T> _dbSet;

        public BaseRepository( DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = new T { ID = id };
            _context.Entry(entity).State = EntityState.Deleted;
        }
    }
}