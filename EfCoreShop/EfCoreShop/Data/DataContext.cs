using Microsoft.EntityFrameworkCore;
using EfCoreShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreShop.Data
{
    public class DataContext : DbContext

    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Shopitem> Shopitems { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                  new Shop()
                  {
                      Id = 1,
                      Name = "Minima"
                  },
                   new Shop()
                   {
                       Id = 2,
                       Name = "Media"
                   });
            modelBuilder.Entity<Shopitem>().HasData(
                  new Shopitem()
                  {
                      Id = 1,
                      Name = "Kola"
                  },
                  new Shopitem()
                  {
                      Id = 2,
                      Name = "Bulka"
                  },
                  new Shopitem()
                  {
                      Id = 3,
                      Name = "Sviestas"
                  },
                   new Shopitem()
                   {
                       Id = 4,
                       Name = "Grietinė"
                   });
        }
    }
}
