using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.DoctorsDetails;
using ApiTest.Utils;

namespace ApiTest.Src.Doctors
{
    [Table("doctors")]
    public class DoctorModel : BaseEntity
    {
        [Required]
        [Column("first_name")]
        [NotNull]
        public required string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [NotNull]
        public required string LastName { get; set; }

        [Required]
        [Column("phone")]
        [NotNull]
        public required string Phone { get; set; }

        [Required]
        [Column("email")]
        [NotNull]
        public required string Email { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; } = false;

        [Required]
        [Column("password")]
        [NotNull]
        public required string Password { get; set; }

        DoctorDetailsModel DoctorDetails { get; set; }
    }
}
