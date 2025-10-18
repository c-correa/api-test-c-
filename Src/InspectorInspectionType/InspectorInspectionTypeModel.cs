using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.InspectionType;
using ApiTest.Src.Inspector;
using ApiTest.Utils;

namespace ApiTest.Src.InspectorInspectionType
{
    [Table("inspector_inspection_types")]
    public class InspectorInspectionTypeModel : BaseEntity
    {
        [Required, Column("id_inspector"), NotNull]
        public int IdInspector { get; set; }

        [Required, Column("id_inspection_type"), NotNull]
        public int IdInspectionType { get; set; }

        // Relationships
        [ForeignKey("IdInspector")]
        public InspectorModel? Inspector { get; set; }

        [ForeignKey("IdInspectionType")]
        public InspectionTypeModel? InspectionType { get; set; }
    }
}
