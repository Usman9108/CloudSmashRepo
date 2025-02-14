using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public class TollExitRepository : ITollExitRepository
    {
        private readonly TollDbContext _context;
        
        public TollExitRepository(TollDbContext context)
        {
            _context = context;
        }
        public void AddExit(TollExit tollExit, TollEntry tollEntry)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.TollExits.Add(tollExit);
                var entry = _context.TollEntries.Attach(tollEntry);
                entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }

        }
    }
}
