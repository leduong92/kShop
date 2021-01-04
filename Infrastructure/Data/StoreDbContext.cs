using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
     public class StoreDbContext : DbContext
     {
          public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
          {
          }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               base.OnModelCreating(modelBuilder);
          }

          public DbSet<Product> Products { get; set; }
     }
}