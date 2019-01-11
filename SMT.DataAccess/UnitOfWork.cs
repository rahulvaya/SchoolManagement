using SMT.Shared1.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMT.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly IDbContext context;

        /// <summary>
        /// The disposed
        /// </summary>
        private bool disposed;

        public UnitOfWork(IServiceLocator serviceLocator)
        {
            this.context = serviceLocator.Resolve<IDbContext>("SchoolDB");
        }

        public IDbContext Context
        {
            get
            {
                return this.context;
            }
        }


        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Save information to database
        /// </summary>
        public void Save()
        {
            this.context.SaveDbContextChanges();
        }

        /// <summary>
        /// Save information to database asynchronous.
        /// </summary>
        /// <returns>Affected rows</returns>
        public async Task<int> SaveAsync()
        {
            return await this.context.SaveDbContextChangesAsync();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }

            this.disposed = true;
        }
    }
}
