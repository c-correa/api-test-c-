using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.InspectionType;
using ApiTest.Src.Inspector;
using ApiTest.Src.Vehicle;
using ApiTest.Utils;

namespace ApiTest.Src.Appointment
{
    [Table("appointments")]
    public class AppointmentModel : BaseEntity
    {
        [Required, Column("id_vehicle"), NotNull]
        public int IdVehicle { get; set; }

        [Required, Column("id_inspector"), NotNull]
        public int IdInspector { get; set; }

        [Required, Column("id_inspection_type"), NotNull]
        public int IdInspectionType { get; set; }

        [Required, Column("date"), NotNull]
        public DateTime Date { get; set; }

        [Required, Column("start_time"), NotNull]
        public TimeSpan StartTime { get; set; }

        [Required, Column("end_time"), NotNull]
        public TimeSpan EndTime { get; set; }

        [Required, Column("status"), StringLength(20), NotNull]
        public string Status { get; set; } = "pending"; 
        // Values: 'pending', 'in_progress', 'completed', 'cancelled'

        [Column("notes")]
        public string? Notes { get; set; }

        // Relaciones
        [ForeignKey("IdVehicle")]
        public VehicleModel? Vehicle { get; set; }

        [ForeignKey("IdInspector")]
        public InspectorModel? Inspector { get; set; }

        [ForeignKey("IdInspectionType")]
        public InspectionTypeModel? InspectionType { get; set; }
    }
}
