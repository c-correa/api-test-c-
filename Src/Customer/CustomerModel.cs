

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Vehicle;
using ApiTest.Utils;

namespace ApiTest.Src.Customer
{
     [Table("customers")]
    public class CustomerModel : BaseEntity
    {
        [Required, Column("name"), StringLength(100), NotNull]
        public string Name { get; set; } = null!;

        [Required, Column("document_type"), StringLength(20), NotNull]
        public string DocumentType { get; set; } = null!;

        [Required, Column("document_number"), StringLength(30), NotNull]
        public string DocumentNumber { get; set; } = null!;

        [Required, Column("phone"), StringLength(20), NotNull]
        public string Phone { get; set; } = null!;

        [Column("email"), StringLength(100)]
        public string? Email { get; set; }

        [Column("address"), StringLength(150)]
        public string? Address { get; set; }

        [Required, Column("registration_date")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Relationship: one customer can have many vehicles
        public ICollection<VehicleModel>? Vehicles { get; set; }
    }
}
