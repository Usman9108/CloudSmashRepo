using Microsoft.EntityFrameworkCore;
using System.Xml;
using TollClassLibrary.Helper;

namespace TollPlazaWebApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecialDiscountDay>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<EntryPoint>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<TollEntry>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<TollExit>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<TollRate>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SpecialDiscountDay>().HasData(
                new SpecialDiscountDay 
                { 
                    Id=11,
                    Month_Day = 814,
                    Name = "Independence Day"
                },
                new SpecialDiscountDay
                {
                    Id=12,
                    Month_Day = 1225,
                    Name = "Christmas Day"
                },
                new SpecialDiscountDay
                {
                    Id=13,
                    Month_Day = 323,
                    Name = "Republic Day"
                }
                );
            modelBuilder.Entity<TollRate>().HasData(
                new TollRate
                {
                    Id=21,
                    Name = StringConstants.BaseRate,
                    Rate = 20
                },
                new TollRate
                {
                     Id=22,
                    Name = StringConstants.DistanceRate,
                    Rate = 0.2
                },
                new TollRate
                {
                    Id=23,
                    Name = StringConstants.WeekendRate,
                    Rate = 1.5
                },
                new TollRate
                {
                    Id = 24,    
                    Name = StringConstants.NumberPlateDiscountRate,
                    Rate = 0.1
                },
                new TollRate
                {
                    Id=25,
                    Name = StringConstants.NationHolidayDiscountRate,
                    Rate = 0.5
                }
                );
            modelBuilder.Entity<EntryPoint>().HasData(
                new EntryPoint
                {
                     Id =1,
                     PointName= StringConstants.ZeroPoint,
                    KMFromZeroPoint = 0
                },
                new EntryPoint
                {
                    Id=2,
                    PointName = StringConstants.NSInterchange,
                    KMFromZeroPoint = 5
                },
                new EntryPoint
                {
                    Id=3,
                    PointName = StringConstants.Ph4Interchange,
                    KMFromZeroPoint = 10
                },
                new EntryPoint
                {
                    Id = 4, 
                    PointName = StringConstants.FerozpurInterchange,
                    KMFromZeroPoint = 17
                },
                new EntryPoint
                {
                    Id = 5,
                    PointName = StringConstants.LakeCityInterchange,
                    KMFromZeroPoint = 24
                },
                new EntryPoint
                {
                    Id = 6,
                    PointName = StringConstants.RaiwandInterchange,
                    KMFromZeroPoint = 29
                },
                new EntryPoint
                {
                    Id = 7,
                    PointName = StringConstants.BahriaInterchange,
                    KMFromZeroPoint = 34
                }
                );
        }
    }
}
