using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EFCoreExample.Models
{
    // public class CompanyContext : DbContext
    // {
    //     public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
    //     {
    //     }
    //
    //     public DbSet<Department> Department { get; set; }
    //     public DbSet<Employee> Employee { get; set; }
    //     public DbSet<Information> Information { get; set; }
    //
    //     
    //     
    //     
    //     public DbSet<Production> Productions { get; set; }
    //     public DbSet<Movie> Movies { get; set; }
    //     public DbSet<Series> Series { get; set; }
    //     public DbSet<Rating> Ratings { get; set; }
    //     public DbSet<Character> Characters { get; set; }
    //     public DbSet<Actor> Actors { get; set; }
    //
    //     
    //     
    //     
    //     public DbSet<Computer> Computer { get; set; }
    //     public DbSet<UsbQuantity> UsbQuantity { get; set; }
    //
    //
    //     protected override void OnModelCreating(ModelBuilder modelBuilder)
    //     {
    //         modelBuilder.Entity<Department>(entity =>
    //         {
    //             entity.Property(e => e.Name)
    //                 .IsRequired()
    //                 .HasMaxLength(50)
    //                 .IsUnicode(false);
    //         });
    //
    //         modelBuilder.Entity<Employee>(entity =>
    //         {
    //             entity.Property(e => e.Designation)
    //                 .IsRequired()
    //                 .HasMaxLength(25)
    //                 .IsUnicode(false);
    //
    //             entity.Property(e => e.Name)
    //                 .IsRequired()
    //                 .HasMaxLength(100)
    //                 .IsUnicode(false);
    //
    //             entity.HasOne(d => d.Department)
    //                 .WithMany(p => p.Employee)
    //                 .HasForeignKey(d => d.DepartmentId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("FK_Employee_Department");
    //         });
    //
    //         PopulateActors(modelBuilder);
    //         PopulateComputers(modelBuilder);
    //
    //         base.OnModelCreating(modelBuilder);
    //
    //     }
    //
    //     private void PopulateActors(ModelBuilder modelBuilder)
    //     {
    //         var movies = new Movie[] {
    //             new Movie { Id = 1, Name = "Avengers: Endgame", WorldwideBoxOfficeGross = 2_797_800_564, DurationInMinutes = 181, Release = new DateTime(2019, 4, 26) },
    //             new Movie { Id = 2, Name = "The Lion King", WorldwideBoxOfficeGross = 1_654_791_102, DurationInMinutes     = 118, Release = new DateTime(2019, 7, 19) },
    //             new Movie { Id = 3, Name = "Ip Man 4", WorldwideBoxOfficeGross = 192_617_891, DurationInMinutes = 105, Release = new DateTime(2019, 12, 25) },
    //             new Movie { Id = 4, Name = "Gemini Man", WorldwideBoxOfficeGross = 166_623_705, DurationInMinutes = 116, Release = new DateTime(2019, 11, 20) },
    //             new Movie { Id = 5, Name = "Downton Abbey", WorldwideBoxOfficeGross = 194_051_302, DurationInMinutes = 120, Release = new DateTime(2020, 9, 20 )}
    //         };
    //         var series = new Series[] {
    //             new Series { Id = 6 , Name = "The Fresh Prince of Bel-Air", NumberOfEpisodes = 148, Release = new DateTime(1990, 9, 10) },
    //             new Series { Id = 7 , Name = "Downton Abbey", NumberOfEpisodes = 52, Release = new DateTime(2010, 09, 26) },
    //             new Series { Id = 8 , Name = "Stranger Things", NumberOfEpisodes = 34 , Release = new DateTime(2016, 7, 11) },
    //             new Series { Id = 9 , Name = "Kantaro: The Sweet Tooth Salaryman", NumberOfEpisodes = 12, Release = new DateTime(2017,7, 14) },
    //             new Series { Id = 10, Name = "The Walking Dead", NumberOfEpisodes = 177 , Release = new DateTime(2010, 10, 31) }
    //         };
    //         var productions = movies
    //             .Cast<Production>()
    //             .Union(series)
    //             .ToList();
    //         modelBuilder.Entity<Movie>().HasData(movies);
    //         modelBuilder.Entity<Series>().HasData(series);
    //         // characters
    //         modelBuilder.Entity<Character>().HasData(new Character[]
    //         {
    //             // movies
    //             new Character { Id = 1, Name = "Tony Stark", ProductionId = 1, ActorId = 1 },
    //             new Character { Id = 2, Name = "Steve Rogers", ProductionId = 1, ActorId = 2 },
    //             new Character { Id = 3, Name = "Okoye", ProductionId = 1, ActorId = 3 },
    //             new Character { Id = 4, Name = "Simba", ProductionId = 2, ActorId = 4 },
    //             new Character { Id = 5, Name = "Nala", ProductionId = 2, ActorId = 5 },
    //             new Character { Id = 6, Name = "Ip Man", ProductionId = 3, ActorId = 6 },
    //             new Character { Id = 7, Name = "Henry Brogan", ProductionId = 4, ActorId = 7 },
    //             new Character { Id = 8, Name = "Violet Crawley", ProductionId = 5, ActorId = 8 },
    //             new Character { Id = 9, Name = "Lady Mary Crawley", ProductionId = 5, ActorId = 9 },
    //             // television
    //             new Character { Id = 10, Name = "Will Smith", ProductionId = 6, ActorId = 7},
    //             new Character { Id = 11, Name = "Hilary Banks", ProductionId = 6, ActorId = 10 },
    //             new Character { Id = 12, Name = "Violet Crawley", ProductionId = 7, ActorId = 8 },
    //             new Character { Id = 13, Name = "Lady Mary Crawley", ProductionId = 7, ActorId = 9 },
    //             new Character { Id = 14, Name = "Eleven", ProductionId = 8, ActorId = 11 },
    //             new Character { Id = 15, Name = "Lucas", ProductionId = 8, ActorId = 12 },
    //             new Character { Id = 16, Name = "Joyce Byers", ProductionId = 8, ActorId = 13 },
    //             new Character { Id = 17, Name = "Jim Hopper", ProductionId = 8, ActorId = 14 },
    //             new Character { Id = 18, Name = "Ametani Kantarou", ProductionId = 9, ActorId = 15},
    //             new Character { Id = 19, Name = "Sano Erika", ProductionId = 9, ActorId = 16 },
    //             new Character { Id = 20, Name = "Daryl Dixon", ProductionId = 10, ActorId = 17 },
    //             new Character { Id = 21, Name = "Michonne", ProductionId = 10, ActorId = 3 },
    //             new Character { Id = 22, Name = "Carol Peletier", ProductionId = 10, ActorId = 18 }
    //         });
    //         // actors
    //         modelBuilder.Entity<Actor>().HasData(new Actor[]
    //         {
    //             new Actor { Id = 1, Name = "Robert Downey Jr." },
    //             new Actor { Id = 2, Name = "Chris Evans" },
    //             new Actor { Id = 3, Name = "Danai Guira" },
    //             new Actor { Id = 4, Name = "Donald Glover" },
    //             new Actor { Id = 5, Name = "Beyoncé" },
    //             new Actor { Id = 6, Name = "Donny Yen" },
    //             new Actor { Id = 7, Name = "Will Smith" },
    //             new Actor { Id = 8, Name = "Maggie Smith" },
    //             new Actor { Id = 9, Name = "Michelle Dockery" },
    //             new Actor { Id = 10, Name = "Karyn Parsons" },
    //             new Actor { Id = 11, Name = "Millie Bobby Brown" },
    //             new Actor { Id = 12, Name = "Caleb McLaughlin" },
    //             new Actor { Id = 13, Name = "Winona Ryder"},
    //             new Actor { Id = 14, Name = "David Harbour" },
    //             new Actor { Id = 15, Name = "Matsuya Onoe" },
    //             new Actor { Id = 16, Name = "Hazuki Shimizu"},
    //             new Actor { Id = 17, Name = "Norman Reedus" },
    //             new Actor { Id = 18, Name = "Melissa McBride" }
    //         });
    //         // let's generate lots of ratings
    //         var random = new Random();
    //         var size = 100;
    //         var sources = new[] {
    //             "Internet",
    //             "Newspaper",
    //             "Magazine",
    //             "App"
    //         };
    //         var ratings = productions
    //             .SelectMany((production, index) => {
    //                 return Enumerable
    //                     .Range(index * 100 + 1, size - 1)
    //                     .Select(id => new Rating
    //                     {
    //                         Id = id,
    //                         ProductionId = production.Id,
    //                         Stars = random.Next(1, 6),
    //                         Source = sources[random.Next(0, 4)]
    //                     }).ToList();
    //             });
    //         modelBuilder.Entity<Rating>().HasData(ratings);
    //     }
    //
    //     private void PopulateComputers(ModelBuilder modelBuilder)
    //     {
    //         // ENUMS
    //         var storageUnit = new StorageUnit[]
    //         {
    //             new StorageUnit {Id = 1, Description = "MB"},
    //             new StorageUnit {Id = 2, Description = "GB"},
    //             new StorageUnit {Id = 3, Description = "TB"},
    //         };
    //
    //         var hardDriveTypes = new HardDriveType[]
    //         {
    //             new HardDriveType {Id = 1, Description = "HDD"},
    //             new HardDriveType {Id = 2, Description = "SDD"},
    //         };
    //
    //         var weightUnits = new WeightUnit[]
    //         {
    //             new WeightUnit {Id = 1, Description = "LB",},
    //             new WeightUnit {Id = 2, Description = "KG",}
    //         };
    //
    //         var usbTypes = new UsbType[]
    //         {
    //             new UsbType {Id = 1, Description = "USB-2"},
    //             new UsbType {Id = 2, Description = "USB-3"},
    //             new UsbType {Id = 3, Description = "USB-C"},
    //         };
    //
    //         modelBuilder.Entity<StorageUnit>().HasData(storageUnit);
    //         modelBuilder.Entity<HardDriveType>().HasData(hardDriveTypes);
    //         modelBuilder.Entity<WeightUnit>().HasData(weightUnits);
    //
    //         modelBuilder.Entity<UsbType>().HasData(usbTypes);
    //
    //         // CLASSES
    //
    //         var rams = new Ram[]
    //         {
    //             new Ram {Id = 1, Size = 2, Unit = EStorageUnit.GB},
    //             new Ram {Id = 2, Size = 8, Unit = EStorageUnit.GB},
    //             new Ram {Id = 3, Size = 16, Unit = EStorageUnit.GB},
    //             new Ram {Id = 4, Size = 32, Unit = EStorageUnit.GB},
    //             new Ram {Id = 5, Size = 512, Unit = EStorageUnit.MB},
    //         };
    //         modelBuilder.Entity<Ram>().HasData(rams);
    //
    //         var hardDrives = new HardDrive[]
    //         {
    //             new HardDrive {Id = 1, Size = 2, StorageUnit = EStorageUnit.TB, HardDriveType = EHardDriveType.HDD},
    //             new HardDrive {Id = 2, Size = 3, StorageUnit = EStorageUnit.TB, HardDriveType = EHardDriveType.HDD},
    //             new HardDrive {Id = 3, Size = 4, StorageUnit = EStorageUnit.TB, HardDriveType = EHardDriveType.HDD},
    //
    //             new HardDrive {Id = 4, Size = 80, StorageUnit = EStorageUnit.GB, HardDriveType = EHardDriveType.SDD},
    //             new HardDrive {Id = 5, Size = 500, StorageUnit = EStorageUnit.GB, HardDriveType = EHardDriveType.SDD},
    //             new HardDrive {Id = 6, Size = 750, StorageUnit = EStorageUnit.GB, HardDriveType = EHardDriveType.SDD},
    //             new HardDrive {Id = 7, Size = 1, StorageUnit = EStorageUnit.TB, HardDriveType = EHardDriveType.SDD},
    //             new HardDrive {Id = 8, Size = 2, StorageUnit = EStorageUnit.TB, HardDriveType = EHardDriveType.SDD},
    //         };
    //         modelBuilder.Entity<HardDrive>().HasData(hardDrives);
    //
    //         var graphicsCards = new GraphicsCard[]
    //         {
    //             new GraphicsCard {Id = 1, Name = "NVIDIA GeForce GTX 770"},
    //             new GraphicsCard {Id = 2, Name = "NVIDIA GeForce GTX 960"},
    //             new GraphicsCard {Id = 3, Name = "Radeon R7360"},
    //             new GraphicsCard {Id = 4, Name = "NVIDIA GeForce GTX 1080"},
    //             new GraphicsCard {Id = 5, Name = "Radeon RX 480"},
    //             new GraphicsCard {Id = 6, Name = "Radeon R9 380"},
    //             new GraphicsCard {Id = 7, Name = "AMD FirePro W4100"}
    //         };
    //         modelBuilder.Entity<GraphicsCard>().HasData(graphicsCards);
    //
    //         var processors = new Processor[]
    //         {
    //             new Processor {Id = 1, Name = "Intel® Celeron™ N3050 Processor"},
    //             new Processor {Id = 2, Name = "AMD FX 4300 Processor"},
    //             new Processor {Id = 3, Name = "AMD Athlon Quad-Core APU Athlon 5150"},
    //             new Processor {Id = 4, Name = "AMD FX 8-Core Black Edition FX-8350"},
    //             new Processor {Id = 5, Name = "AMD FX 8-Core Black Edition FX-8370 "},
    //             new Processor {Id = 6, Name = "Intel Core i7-6700K 4GHz Processor"},
    //             new Processor {Id = 7, Name = "Intel® Core™ i5-6400 Processor"},
    //             new Processor {Id = 8, Name = "Intel Core i7 Extreme Edition 3 GHz Processor"},
    //         };
    //         modelBuilder.Entity<Processor>().HasData(processors);
    //
    //         List<Computer> computers = new List<Computer>()
    //         {
    //             new Computer
    //             {
    //                 Id = 1, RamId = 2, HardDriveId = 7, GraphicsCardId = 1, WeightQuantity = 8.1m, WeightUnitId = 2, Psu = 500, ProcessorId = 1
    //             },
    //             new Computer
    //             {
    //                 Id = 2, RamId = 3, HardDriveId = 1, GraphicsCardId = 2, WeightQuantity = 12m, WeightUnitId = 2, Psu = 500, ProcessorId = 2,
    //             },
    //             new Computer
    //             {
    //                 Id = 3, RamId = 2, HardDriveId = 2, GraphicsCardId = 3, WeightQuantity = 16m, WeightUnitId = 1, Psu = 450, ProcessorId = 3,
    //             },
    //             new Computer
    //             {
    //                 Id = 4, RamId = 3, HardDriveId = 3, GraphicsCardId = 4, WeightQuantity = 13.8m, WeightUnitId = 1, Psu = 500, ProcessorId = 4,
    //             },
    //             new Computer
    //             {
    //                 Id = 5, RamId = 4, HardDriveId = 6, GraphicsCardId = 5, WeightQuantity = 7m, WeightUnitId = 2, Psu = 1000, ProcessorId = 5,
    //             },
    //             new Computer
    //             {
    //                 Id = 6, RamId = 4, HardDriveId = 8, GraphicsCardId = 6, WeightQuantity = 6m, WeightUnitId = 2, Psu = 450, ProcessorId = 6,
    //             },
    //             new Computer
    //             {
    //                 Id = 7, RamId = 2, HardDriveId = 1, GraphicsCardId = 4, WeightQuantity = 15m, WeightUnitId = 1, Psu = 1000, ProcessorId = 7,
    //             },
    //             new Computer
    //             {
    //                 Id = 8, RamId = 3, HardDriveId = 5, GraphicsCardId = 1, WeightQuantity = 8m, WeightUnitId = 1, Psu = 750, ProcessorId = 7,
    //             },
    //             new Computer
    //             {
    //                 Id = 9, RamId = 1, HardDriveId = 1, GraphicsCardId = 7, WeightQuantity = 9m, WeightUnitId = 2, Psu = 508, ProcessorId = 8,
    //             },
    //             new Computer
    //             {
    //                 Id = 10, RamId = 5, HardDriveId = 4, GraphicsCardId = 5, WeightQuantity = 22m, WeightUnitId = 1, Psu = 700, ProcessorId = 7,
    //             }
    //         };
    //         modelBuilder.Entity<Computer>().HasData(computers);
    //     }
    // }
}