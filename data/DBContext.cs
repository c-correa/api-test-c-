using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using ApiTest.Src.Owners.Models;
using ApiTest.Src.Pets.Models;
using ApiTest.Src.OwnersPets.Models;

namespace ApiTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Env.Load();
                var connectionString = Environment.GetEnvironmentVariable("URL_CONNECT_BD");
                optionsBuilder.UseNpgsql(connectionString);
            }
            
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<OwnersPet> OwnersPets { get; set; }


    }
}
