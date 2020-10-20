
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public interface IGenericRepository<TEntity,T> where TEntity : BaseEntity<T> where T : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        Task SaveAsync();
    }
}
