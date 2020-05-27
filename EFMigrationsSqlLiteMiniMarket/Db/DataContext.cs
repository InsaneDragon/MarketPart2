using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFMigrationsSqlLiteMiniMarket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFMigrationsSqlLiteMiniMarket.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Cattegories>().HasData(
              new Cattegories
              {
                  Id = 1,
                  Name = "Dairy Products"
              },
               new Cattegories
               {
                   Id = 2,
                   Name = "Meat Products"
               },
                new Cattegories
                {
                    Id = 3,
                    Name = "Fruits"
                },
                 new Cattegories
                 {
                     Id = 4,
                     Name = "Vegetables"
                 },
                 new Cattegories
                 {
                     Id = 5,
                     Name = "Bread"
                 }
                ) ;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cattegories> Cattegories { get; set; }
    }
}
