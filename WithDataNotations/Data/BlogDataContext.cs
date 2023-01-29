using WithDataNotation.Models;
using Microsoft.EntityFrameworkCore;

namespace WithDataNotation.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DEVELOPMENT;Database=Blog;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}