
using System;
using TollPlazaWebApi.Manager;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public class SpecialDiscountDayRepository : IRepository<SpecialDiscountDay>
    {
        private readonly TollDbContext _context;

        public SpecialDiscountDayRepository(TollDbContext context)
        {
            _context = context;
        }
        public void Add(SpecialDiscountDay entity)
        {
            _context.SpecialDiscounts.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var specialDiscount = _context.SpecialDiscounts.Find(id)!;
            if (specialDiscount != null)
            {
                _context.SpecialDiscounts.Remove(specialDiscount);
                _context.SaveChanges();
            }
        }

        public SpecialDiscountDay? Get(int id)
        {
            return _context.SpecialDiscounts.Find(id);
        }

        public IEnumerable<SpecialDiscountDay> GetAll()
        {
            return _context.SpecialDiscounts;
        }

        public void Update(SpecialDiscountDay entity)
        {
            var specialDiscount = _context.SpecialDiscounts.Attach(entity);
            specialDiscount.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
