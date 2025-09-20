using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Stores { get; set; } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=dpg-d2oias7fte5s738b7nug-a.oregon-postgres.render.com;Port=5432;Username=pets;Password=8mPUBMxaTTBNRc4H9mGHc0EKSzSNIqy5;Database=pets_px49");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("stores"); 
    }

    public async Task<List<User>> FindAll()
    {
        return await Stores.ToListAsync();
    }
}
