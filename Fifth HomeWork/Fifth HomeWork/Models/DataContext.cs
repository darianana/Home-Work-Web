using Microsoft.EntityFrameworkCore;
namespace Fifth_HomeWork.Models
{
    public class DataContext: DbContext
    {
        public DbSet<St_type> Types { get; set; }
        public DbSet<Staging> Stagings { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}