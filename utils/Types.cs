using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTest.Utils
{

    public interface IBaseEntity
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime? UpdatedAt { get; set; } // Es mejor que sea nullable

        DateTime? DeletedAt { get; set; }
    }

  
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // valor por defecto

        [Column("update_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; } = null;
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

    public class OkResult
    {
        public bool Ok { get; set; }
    }
}