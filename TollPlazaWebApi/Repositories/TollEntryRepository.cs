using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public class TollEntryRepository : ITollEntryRepository
    {
        private readonly TollDbContext _context;
        public TollEntryRepository(TollDbContext context)
        {
            _context = context;
        }
        public void Add(TollEntry entity)
        {
            _context.TollEntries.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var tollEntry = _context.TollEntries.Find(id);
            if(tollEntry != null)
            {
                _context.TollEntries.Remove(tollEntry);
                _context.SaveChanges();
            }
        }

        public TollEntry? Get(int id)
        {
            return _context.TollEntries.Find(id);
        }

        public IEnumerable<TollEntry> GetAll()
        {
            return _context.TollEntries;
        }

        public TollEntry? GetByVehicleNumber(string vehicleNumber)
        {
            return _context.TollEntries.FirstOrDefault(x => x.VehicleNumber == vehicleNumber);
        }

        public void Update(TollEntry entity)
        {
            var tollEntry =_context.TollEntries.Attach(entity);
            tollEntry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
