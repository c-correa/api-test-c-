using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.Customer.Dto
{
    public class CreateCustomerDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string DocumentNumber { get; set; } = string.Empty;

        [Required, StringLength(15)]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

            [Required, StringLength(20)]
    public string DocumentType { get; set; } = string.Empty; // <- obligatorio

    }

    public class ReadCustomerDto
    {
        [Display(Name = "Customer ID")]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Document Number")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Home Address")]
        public string Address { get; set; } = string.Empty;

        // Optional: list of vehicle plates
        [Display(Name = "Vehicle Plates")]
        public List<string> VehiclePlates { get; set; } = new();
    }

    public class UpdateCustomerDto
    {
        [Required]
        [Display(Name = "Customer ID")]
        public int Id { get; set; }


    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [Display(Name = "Document Number")]
    public string DocumentNumber { get; set; } = string.Empty;

    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Home Address")]
    public string Address { get; set; } = string.Empty;
    }
}
