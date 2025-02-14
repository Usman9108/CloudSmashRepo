using TollPlazaWebApi.Manager;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public class EntryPointRepository : IRepository<EntryPoint>
    {
        private readonly TollDbContext _context;
        public EntryPointRepository(TollDbContext context)
        {
            _context = context;
        }
        public void Add(EntryPoint entity)
        {
            _context.EntryPoints.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entryPoint = _context.EntryPoints.Find(id)!;
            if (entryPoint != null)
            {
                _context.EntryPoints.Remove(entryPoint);
                _context.SaveChanges();
            }
        }
        public EntryPoint? Get(int id)
        {
            return _context.EntryPoints.Find(id);
        }
        public IEnumerable<EntryPoint> GetAll()
        {
            return _context.EntryPoints;
        }
        public void Update(EntryPoint entity)
        {
            var entryPoint = _context.EntryPoints.Attach(entity);
            entryPoint.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
