using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMT.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IDbContext Context { get; }

        void Save();

        Task<int> SaveAsync();

        void Dispose(bool disposing);
    }
}
