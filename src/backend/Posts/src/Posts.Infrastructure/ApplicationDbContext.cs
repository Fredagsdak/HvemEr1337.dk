using Microsoft.EntityFrameworkCore;
using Posts.Infrastructure.Models;

namespace Posts.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}