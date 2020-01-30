using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace TicketsStore.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Staging> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bucket> Buckets{ get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bucket>()
                .HasKey(t => new { t.StagingId, t.UserId });
        }
    }
}
