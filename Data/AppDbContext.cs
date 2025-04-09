using Microsoft.EntityFrameworkCore;
using PhamCongLuan_2122110541.Models;

namespace PhamCongLuan_2122110541.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

