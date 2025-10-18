using System;
using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.Appointment.Dto
{
    public class CreateAppointmentDto
    {
        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int InspectorId { get; set; }

        [Required]
        public int InspectionTypeId { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Scheduled";

        [StringLength(200)]
        public string Notes { get; set; }
    }

    public class ReadAppointmentDto
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        // --- Related Info (for UI display) ---
        public string VehiclePlate { get; set; }
        public string CustomerName { get; set; }
        public string InspectorName { get; set; }
        public string InspectionTypeName { get; set; }
    }

    public class UpdateAppointmentDto
    {
        [Required]
        public int Id { get; set; }

        public DateTime? AppointmentDate { get; set; }

        public int? VehicleId { get; set; }
        public int? CustomerId { get; set; }
        public int? InspectorId { get; set; }
        public int? InspectionTypeId { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }
    }
}
