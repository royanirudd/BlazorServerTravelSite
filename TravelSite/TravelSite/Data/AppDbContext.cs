using Microsoft.EntityFrameworkCore;
using TravelSite.Models;

namespace TravelSite.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships
        modelBuilder.Entity<Hotel>()
            .HasOne(h => h.Category)
            .WithMany(c => c.Hotels)
            .HasForeignKey(h => h.CategoryId);
    }
}
