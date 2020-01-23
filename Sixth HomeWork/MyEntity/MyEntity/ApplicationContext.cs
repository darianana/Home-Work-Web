using Microsoft.EntityFrameworkCore;

namespace MyEntity
{
    public class ApplicationContext:DbContext
    {
        public DbSet<St_type> Types { get; set; }
            public DbSet<Staging> Stagings { get; set; }
            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=myEntity;Trusted_Connection=True;");
            }
        }
    }
