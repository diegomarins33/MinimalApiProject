using Microsoft.EntityFrameworkCore;

namespace MinimalApiProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<PostModel> Posts { get; set; }
    }
}
