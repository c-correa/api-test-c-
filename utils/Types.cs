using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTest.Utils
{
    public class IEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("update_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; } = null;
    }

    public interface IEntityError
    {
        string Name { get; set; }
        string Message { get; set; }
        string Stack { get; set; }
        string Status { get; set; }
    }

    public class ErrorResponse
    {
        public string Name { get; set; } = "";
        public string Message { get; set; } = "";
        public string? Detail { get; set; }
        public string? Hint { get; set; }
        public string? SqlState { get; set; }
        public string? Stack { get; set; }
        public int Status { get; set; }
    }


}