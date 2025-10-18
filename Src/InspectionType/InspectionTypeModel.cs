using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Appointment;
using ApiTest.Src.InspectorInspectionType;
using ApiTest.Utils;

namespace ApiTest.Src.InspectionType
{
    [Table("inspection_types")]
    public class InspectionTypeModel : BaseEntity
    {
        [Required, Column("name"), StringLength(50), NotNull]
        public string Name { get; set; } = null!;

        [Column("description"), StringLength(200)]
        public string? Description { get; set; }

        [Required, Column("estimated_duration_minutes"), NotNull]
        public int EstimatedDurationMinutes { get; set; }

        // Relationships
        public ICollection<AppointmentModel>? Appointments { get; set; }

        // Many-to-many: InspectionType ↔ Inspector
        public ICollection<InspectorInspectionTypeModel>? InspectorInspectionTypes { get; set; }
    }
}
