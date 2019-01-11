using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMT.DataAccess.Base
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : class
    {
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetEntityByIdAsync(object id);

        Task<TEntity> GetDetailedEntityByIdAsync(object id);

        TEntity Add(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity, int? facilityId = null);

        bool Delete(TEntity entity);

        Task<bool> DeleteEntityAsync(string entityName, Guid entityId);
    }
}
