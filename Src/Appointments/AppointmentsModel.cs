using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Doctors;
using ApiTest.Src.HistoryRecords;
using ApiTest.Src.Pets;
using ApiTest.Utils;

namespace ApiTest.Src.Appointments
{
    [Table("appointments")]
    public class AppointmentsModel : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("appointment_date")]
        [NotNull]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [Column("appointment_time")]
        [NotNull]
        public TimeSpan AppointmentTime { get; set; }

        [Column("notes")]
        public string? Notes { get; set; }

        // Relación con el paciente
        [Required]
        [ForeignKey("Pet")]
        [Column("pet_id")]
        [NotNull]
        public int PatientId { get; set; }

        public virtual PetModel Pet { get; set; } = null!;

        // Relación con el veterinario
        [Required]
        [ForeignKey("Doctor")]
        [Column("doctor_id")]
        [NotNull]
        public int DoctorId { get; set; }

        public virtual DoctorModel Veterinarian { get; set; } = null!;

         [Required]
        [ForeignKey("HistoryRecord")]
        [Column("history_record_id")]
        [NotNull]
        public int HistoryRecordId { get; set; }

        public virtual ICollection<HistoryRecordModel> HistoryRecords { get; set; } = new List<HistoryRecordModel>();
    }
}
