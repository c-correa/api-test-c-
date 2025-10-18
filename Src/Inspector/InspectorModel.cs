using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Appointment;
using ApiTest.Src.InspectorInspectionType;
using ApiTest.Utils;

namespace ApiTest.Src.Inspector
{
    [Table("inspectors")]
    public class InspectorModel : BaseEntity
    {
        [Required, Column("name"), StringLength(100), NotNull]
        public string Name { get; set; } = null!;

        [Required, Column("document_number"), StringLength(30), NotNull]
        public string DocumentNumber { get; set; } = null!;

        [Required, Column("phone"), StringLength(20), NotNull]
        public string Phone { get; set; } = null!;

        [Column("email"), StringLength(100)]
        public string? Email { get; set; }

        [Required, Column("status"), StringLength(15), NotNull]
        public string Status { get; set; } = "active"; // 'active' | 'inactive'

        // Relationships
        public ICollection<AppointmentModel>? Appointments { get; set; }

        // Many-to-many: Inspector ↔ InspectionType
public ICollection<InspectorInspectionTypeModel> InspectorInspectionTypes { get; set; } = new List<InspectorInspectionTypeModel>();
    }
}
