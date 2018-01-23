using Microsoft.EntityFrameworkCore;
using schoolreport.Models;

namespace schoolreport.Persistence
{
    public class SchoolRDbContext :DbContext
    {
        public DbSet<District> Districts { get; set; }

        public DbSet<Zone> Zones { get; set; }

        public DbSet<School> Schools { get; set; }
        public SchoolRDbContext(DbContextOptions<SchoolRDbContext> options)
        : base(options)
        {

        }
    }
}