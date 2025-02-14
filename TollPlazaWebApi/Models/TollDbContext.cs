using Microsoft.EntityFrameworkCore;

namespace TollPlazaWebApi.Models
{
    public class TollDbContext : DbContext
    {
        public TollDbContext(DbContextOptions<TollDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<TollRate> TollRates { get; set; }
        public DbSet<EntryPoint> EntryPoints { get; set; }
        public DbSet<TollEntry> TollEntries { get; set; }
        public DbSet<TollExit> TollExits { get; set; }
        public DbSet<SpecialDiscountDay> SpecialDiscounts { get; set; }
    }
    
}
