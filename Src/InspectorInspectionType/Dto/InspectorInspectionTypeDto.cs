using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.Owners.Dto
{
    public class CreateInspectorInspectionTypeDto
    {
        [Required]
        public int IdInspector { get; set; }

        [Required]
        public int IdInspectionType { get; set; }
    }

    public class ReadInspectorInspectionTypeDto
    {
        public int IdInspector { get; set; }
        public string InspectorName { get; set; }

        public int IdInspectionType { get; set; }
        public string InspectionTypeName { get; set; }
    }

    // Optional: for deleting relationships
    public class DeleteInspectorInspectionTypeDto
    {
        [Required]
        public int IdInspector { get; set; }

        [Required]
        public int IdInspectionType { get; set; }
    }
}
