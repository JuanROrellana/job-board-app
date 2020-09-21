using JobBoardApp.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Models.JobBoard> BoardGames { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobBoardConfiguration());
        }
    }
}
