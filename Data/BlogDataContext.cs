using BALTA.IO_FundamentosEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BALTA.IO_FundamentosEF.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=DEVELOPMENT;Database=Blog;Integrated Security=True;TrustServerCertificate=True");

    }
}