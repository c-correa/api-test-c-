using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.OwnersPets.Models;
using ApiTest.Src.Pets.Models;
using ApiTest.Utils;

namespace ApiTest.Src.Owners.Models
{
    [Table("owners")]
    public class Owner : BaseEntity
    {
        [Required]
        [Column("name")]
        [NotNull]
        public required string Name { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; } = false;

        [Required]
        [Column("password")]
        public required string Password { get; set; }

        List<Pet> pets { get; set; } = [];

        List<OwnersPet> OwnersPets { get; set; } = [];
    }
}
