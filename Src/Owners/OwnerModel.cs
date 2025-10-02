using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Utils;

namespace ApiTest.Src.Users
{
    [Table("Users")]
    public class User : BaseEntity
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
    }
}
