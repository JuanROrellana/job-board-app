using Microsoft.EntityFrameworkCore;

namespace JobBoardApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Models.JobBoard> BoardGames { get; set; }
    }
}
