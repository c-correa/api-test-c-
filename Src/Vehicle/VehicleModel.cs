

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Appointment;
using ApiTest.Src.Customer;
using ApiTest.Utils;

namespace ApiTest.Src.Vehicle
{
    [Table("vehicles")]
    public class VehicleModel : BaseEntity
    {
        [Required, Column("id_customer"), NotNull]
        public int IdCustomer { get; set; }

        [Required, Column("license_plate"), StringLength(10), NotNull]
        public string LicensePlate { get; set; } = null!;

        [Required, Column("brand"), StringLength(50), NotNull]
        public string Brand { get; set; } = null!;

        [Required, Column("model"), StringLength(50), NotNull]
        public string Model { get; set; } = null!;

        [Required, Column("year")]
        public int Year { get; set; }
        
        [Required, Column("vehicle_type"), StringLength(30), NotNull]
        public string VehicleType { get; set; } = null!;

     
        // Relationship: each vehicle belongs to one customer
        [ForeignKey("IdCustomer")]
        public CustomerModel? Customer { get; set; }
        // Relationship: one vehicle can have many appointments
        public ICollection<AppointmentModel>? Appointments { get; set; }
    }
}
