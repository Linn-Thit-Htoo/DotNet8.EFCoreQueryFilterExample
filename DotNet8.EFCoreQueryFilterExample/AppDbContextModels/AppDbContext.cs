using Microsoft.EntityFrameworkCore;

namespace DotNet8.EFCoreQueryFilterExample.AppDbContextModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tbl_Blog> Tbl_Blog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Blog>().HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
