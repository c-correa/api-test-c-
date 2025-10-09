using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.OwnersPets.Models;
using ApiTest.Utils;

namespace ApiTest.Src.DoctorsDetails.Models
{
    [Table("doctor_details")]
    public class DoctorDetails : BaseEntity
    {
        [Required]
        [Column("doctor_id")]
        [NotNull]
        public required int DoctorId { get; set; }

        [Required]
        [Column("license_number")]
        [NotNull]
        public required string LicenseNumber { get; set; }

        [Required]
        [Column("specialty")]
        [NotNull]
        public required string Specialty { get; set; }

        [Required]
        [Column("years_experience")]
        [NotNull]
        public required int YearsExperience { get; set; }

        [Column("education")]
        public required string Education { get; set; }

        List<OwnersPet> OwnersPets { get; set; } = [];
    }
}
