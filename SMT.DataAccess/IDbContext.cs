using System.Threading.Tasks;

namespace SMT.DataAccess
{
    public interface IDbContext
    {
        void Dispose();
        void ResetStateChanges();
        int SaveDbContextChanges();
        Task<int> SaveDbContextChangesAsync();
    }
}