using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace MyStore.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Staging> Stagings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bucket> Buckets{ get; set; }
        public DbSet<Role> Roles { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role admin = new Role {Id = 1, Name = "admin"};
            Role moderator = new Role {Id = 2, Name = "moderator"};
            Role consultant = new Role {Id = 3, Name = "consultant"};
            Role customer = new Role {Id = 4, Name = "customer"};

            User admin_u = new User { Id = 1, Name = "admin", Password = "adminadmin", RoleId = admin.Id};
            User moderator_u = new User { Id = 2, Name = "moderator", Password = "moderator1", RoleId = moderator.Id};
            User consultant_u = new User { Id = 3, Name = "consultant", Password = "consultant1", RoleId = consultant.Id};
            
            modelBuilder.Entity<Role>().HasData(new Role[] { admin, moderator, consultant, customer});
            modelBuilder.Entity<User>().HasData( new User[] { admin_u, moderator_u, consultant_u });
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Bucket>()
                .HasKey(t => new { t.StagingId, t.UserId });
        }
    }
}