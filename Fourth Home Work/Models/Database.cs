using Microsoft.EntityFrameworkCore;

namespace Fourth_Home_Work.Models
{
    public class Database : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }

        public Database(DbContextOptions<Database> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}