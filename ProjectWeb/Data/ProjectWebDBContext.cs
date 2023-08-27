using Microsoft.EntityFrameworkCore;
using ProjectWeb.Models.Domain;

namespace ProjectWeb.Data
{
    public class ProjectWebDBContext : DbContext
    {
        public ProjectWebDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }

    }
}
