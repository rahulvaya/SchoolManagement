using SMT.Entities.EntityBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMT.DataAccess.Base
{
    public class RepositoryBase<TEntity, TId> : IRepositoryBase<TEntity, TId>, IDisposable where TEntity : EntityBase<TId>
    {
       
        private readonly DbSet<TEntity> entitySet;
       
        private DbContext entityContext;

        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            if (unitOfWork != null)
            {
                this.entityContext = unitOfWork.Context as DbContext;
            }
            else
            {
                throw new DataException("Entity Context is null");
            }

            this.entitySet = this.entityContext.Set<TEntity>();
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Added entity</returns>
        public virtual TEntity Add(TEntity entity)
        {
            TEntity addedEntity = this.entitySet.Add(entity);
            return addedEntity;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>true if successfully deleted else false</returns>
        public virtual bool Delete(TEntity entity)
        {
            this.entitySet.Attach(entity);
            this.entitySet.Remove(entity);
            return true;
        }

        public Task<bool> DeleteEntityAsync(string entityName, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetDetailedEntityByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetEntityByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity, int? facilityId = null)
        {
            throw new NotImplementedException();
        }
    }
}
