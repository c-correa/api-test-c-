using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using ApiTest.Users;

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
                Env.Load(); // carga variables del .env
                var connectionString = Environment.GetEnvironmentVariable("URL_CONNECT_BD");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        public DbSet<User> Users { get; set; }
    }
}
