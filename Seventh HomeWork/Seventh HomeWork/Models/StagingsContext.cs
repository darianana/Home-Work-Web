using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Seventh_HomeWork.Models
{
    public class StagingsContext : DbContext
    {
        public DbSet<Staging> Stagings { get; set; }
        public StagingsContext(DbContextOptions<StagingsContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
