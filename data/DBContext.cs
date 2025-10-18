

using ApiTest.Src.Appointment;
using ApiTest.Src.Customer;
using ApiTest.Src.InspectionType;
using ApiTest.Src.Inspector;
using ApiTest.Src.InspectorInspectionType;
using ApiTest.Src.Vehicle;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Env.Load();
                var connectionString = Environment.GetEnvironmentVariable("URL_CONNECT_BD");

                if (string.IsNullOrEmpty(connectionString))
                    throw new InvalidOperationException("La variable de entorno 'URL_CONNECT_BD' no está configurada.");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime))
                    {
                        property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                            v => v.ToUniversalTime(),   // Convert to UTC when saving
                            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Convert to UTC when reading
                        ));
                    }
                }
            }
        }


        public DbSet<AppointmentModel> Appointments { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<InspectorModel> Inspectors { get; set; }
        public DbSet<InspectorInspectionTypeModel> InspectorInspectionTypes { get; set; }
        public DbSet<InspectionTypeModel> InspectionType { get; set; }
        public DbSet<VehicleModel> Vehicle { get; set; }
    }
}
