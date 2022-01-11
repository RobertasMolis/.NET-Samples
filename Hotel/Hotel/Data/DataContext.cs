using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cleaner> cleaners { get; set; }
        public DbSet<CleanerRoom> CleanerRooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CleanerRoom>().HasKey(bc => new { bc.CleanerId, bc.RoomId });
        }
    }
}
