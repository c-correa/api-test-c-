using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Doctors;
using ApiTest.Src.OwnerPets;
using ApiTest.Utils;

namespace ApiTest.Src.DoctorsDetails
{
    [Table("doctor_details")]
    public class DoctorDetailsModel : BaseEntity
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

        DoctorModel Doctor { get; set; }
    }
}
