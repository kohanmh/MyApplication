
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public class GenericRepository<TEntity, T> : IGenericRepository<TEntity, T> where TEntity : BaseEntity<T> where T : class 
    {
        internal DataBaseContext context;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(DataBaseContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public async Task<T> Create(TEntity entity)
        {
           await dbSet.AddAsync(entity);
            return entity.Key;
        }

        public void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public void Delete(Guid id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Edit(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<IEnumerable<TEntity>> Filter()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> Filter(Func<TEntity, bool> predicate)
        {
            throw  new  NotImplementedException();
        }
        public async Task<TEntity> FirstOrDefault()
        {
            return await dbSet.SingleOrDefaultAsync();
        }


        public virtual async Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return  dbSet.Where(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(predicate).SingleOrDefaultAsync();
        }
    }
}
