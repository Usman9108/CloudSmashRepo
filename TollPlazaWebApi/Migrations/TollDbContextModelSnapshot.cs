﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TollPlazaWebApi.Models;

#nullable disable

namespace TollPlazaWebApi.Migrations
{
    [DbContext(typeof(TollDbContext))]
    partial class TollDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TollPlazaWebApi.Models.EntryPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KMFromZeroPoint")
                        .HasColumnType("int");

                    b.Property<string>("PointName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EntryPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KMFromZeroPoint = 0,
                            PointName = "Zero Point"
                        },
                        new
                        {
                            Id = 2,
                            KMFromZeroPoint = 5,
                            PointName = "NS Interchange"
                        },
                        new
                        {
                            Id = 3,
                            KMFromZeroPoint = 10,
                            PointName = "Ph4 Interchange"
                        },
                        new
                        {
                            Id = 4,
                            KMFromZeroPoint = 17,
                            PointName = "Ferozpur Interchange"
                        },
                        new
                        {
                            Id = 5,
                            KMFromZeroPoint = 24,
                            PointName = "Lake City Interchange"
                        },
                        new
                        {
                            Id = 6,
                            KMFromZeroPoint = 29,
                            PointName = "Raiwand Interchange"
                        },
                        new
                        {
                            Id = 7,
                            KMFromZeroPoint = 34,
                            PointName = "Bahria Interchange"
                        });
                });

            modelBuilder.Entity("TollPlazaWebApi.Models.SpecialDiscountDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Month_Day")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SpecialDiscounts");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Month_Day = 814,
                            Name = "Independence Day"
                        },
                        new
                        {
                            Id = 12,
                            Month_Day = 1225,
                            Name = "Christmas Day"
                        },
                        new
                        {
                            Id = 13,
                            Month_Day = 323,
                            Name = "Republic Day"
                        });
                });

            modelBuilder.Entity("TollPlazaWebApi.Models.TollEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EntryPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TollEntries");
                });

            modelBuilder.Entity("TollPlazaWebApi.Models.TollExit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DistanceTraveled")
                        .HasColumnType("float");

                    b.Property<int>("EntryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExitPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TollAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.ToTable("TollExits");
                });

            modelBuilder.Entity("TollPlazaWebApi.Models.TollRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TollRates");

                    b.HasData(
                        new
                        {
                            Id = 21,
                            Name = "BaseRate",
                            Rate = 20.0
                        },
                        new
                        {
                            Id = 22,
                            Name = "DistanceRate",
                            Rate = 0.2
                        },
                        new
                        {
                            Id = 23,
                            Name = "WeekEndDate",
                            Rate = 1.5
                        },
                        new
                        {
                            Id = 24,
                            Name = "NumberPlateDiscountRate",
                            Rate = 0.1
                        },
                        new
                        {
                            Id = 25,
                            Name = "NationHolidayDiscountRate",
                            Rate = 0.5
                        });
                });

            modelBuilder.Entity("TollPlazaWebApi.Models.TollExit", b =>
                {
                    b.HasOne("TollPlazaWebApi.Models.TollEntry", "TollEntry")
                        .WithMany()
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TollEntry");
                });
#pragma warning restore 612, 618
        }
    }
}
