using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyEntity_6_2.Models
{
    public class ApplicationContext : DbContext
    {


        public DbSet<St_type> Types { get; set; }
        public DbSet<Staging> Stagings { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=myEntity2;Trusted_Connection=True;");
           
        }
    }
}
