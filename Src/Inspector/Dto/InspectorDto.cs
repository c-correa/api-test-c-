using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.Owners.Dto
{
    public class CreateInspectorDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = null!;   // Cambiado de FullName → Name

        [Required, StringLength(20)]
        public string DocumentNumber { get; set; } = null!;

        [Required, StringLength(15)]
        public string Phone { get; set; } = null!;  // Cambiado de PhoneNumber → Phone

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        public int InspectionTypeId { get; set; }
    }

    public class ReadInspectorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;       // Cambiado de FullName → Name
        public string DocumentNumber { get; set; } = null!;
        public string Phone { get; set; } = null!;      // Cambiado de PhoneNumber → Phone
        public string Email { get; set; } = null!;

        // Related info
        public string InspectionTypeName { get; set; } = string.Empty;
    }

    public class UpdateInspectorDto
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }      // Cambiado de FullName → Name

        [StringLength(20)]
        public string? DocumentNumber { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }     // Cambiado de PhoneNumber → Phone

        [EmailAddress, StringLength(100)]
        public string? Email { get; set; }

        public int? InspectionTypeId { get; set; }
    }
}
