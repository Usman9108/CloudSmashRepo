using TollPlazaWebApi.Manager;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public class TollRateRepository : IRepository<TollRate>
    {
        private readonly TollDbContext _context;
        public TollRateRepository(TollDbContext context)
        {
            _context = context;
        }
        public void Add(TollRate entity)
        {
            _context.TollRates.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var tollRate = _context.TollRates.Find(id);
            if (tollRate != null)
            {
                _context.TollRates.Remove(tollRate);
                _context.SaveChanges();
            }
        }
        public TollRate? Get(int id)
        {
            return _context.TollRates.Find(id);
        }
        public IEnumerable<TollRate> GetAll()
        {
            return _context.TollRates;
        }
        public void Update(TollRate entity)
        {
            var tollRate = _context.TollRates.Attach(entity);
            tollRate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
