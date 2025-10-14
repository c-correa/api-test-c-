using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using ApiTest.Src.Owners;
using ApiTest.Src.Pets;
using ApiTest.Src.OwnerPets;
using ApiTest.Src.Appointments;
using ApiTest.Src.AvailabilitySchedule;
using ApiTest.Src.Doctors;
using ApiTest.Src.DoctorDetails;
using ApiTest.Src.HistoryRecords;

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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OwnerPetsModel>()
                .HasKey(op => new { op.OwnerId, op.PetId }); // clave compuesta

            modelBuilder.Entity<OwnerPetsModel>()
                .HasOne(op => op.Owner)
                .WithMany(o => o.OwnerPets)
                .HasForeignKey(op => op.OwnerId);

            modelBuilder.Entity<OwnerPetsModel>()
                .HasOne(op => op.Pet)
                .WithMany(p => p.OwnerPets)
                .HasForeignKey(op => op.PetId);
        }

        public DbSet<OwnerModel> Owners { get; set; }
        public DbSet<PetModel> Pets { get; set; }
        public DbSet<OwnerPetsModel> OwnersPets { get; set; }
        public DbSet<AppointmentsModel> Appointments { get; set; }
        public DbSet<AvailabilityScheduleModel> AvailabilitySchedule { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<DoctorDetailsModel> DoctorDetails { get; set; }
        public DbSet<HistoryRecordModel> HistoryRecords { get; set; }
    }
}
