using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.Vehicle.Dto
{
    public class CreateVehicleDto
    {
        [Required, StringLength(10)]
        public string LicensePlate { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Brand { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public int IdCustomer { get; set; }  // corresponde a IdCustomer en el modelo

        [Required, StringLength(30)]
        public string VehicleType { get; set; } = string.Empty; // obligatorio según el modelo

    }

    public class ReadVehicleDto
    {
        public int Id { get; set; }

        public string LicensePlate { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }

        public string VehicleType { get; set; } = string.Empty;
    }

    public class UpdateVehicleDto
    {
        [Required]
        public int Id { get; set; }

        [StringLength(10)]
        public string? LicensePlate { get; set; }

        [StringLength(50)]
        public string? Brand { get; set; }

        [StringLength(50)]
        public string? Model { get; set; }

        public int? Year { get; set; }

        public int? CustomerId { get; set; }  // corresponde a IdCustomer

        [StringLength(30)]
        public string? VehicleType { get; set; }

    }
}
