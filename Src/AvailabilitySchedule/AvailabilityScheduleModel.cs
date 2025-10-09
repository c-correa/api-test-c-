using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Utils;

namespace ApiTest.Src.AvailabilitySchedule
{
    [Table("availability_schedule")]
    public class AvailabilityScheduleModel :  BaseEntity
    {
        [Required]
        [Column("hour")]
        [NotNull]
        public TimeSpan Hour { get; set; }  // Hora obligatoria

        [Column("monday")]
        public bool Monday { get; set; } = true;

        [Column("tuesday")]
        public bool Tuesday { get; set; } = true;

        [Column("wednesday")]
        public bool Wednesday { get; set; } = true;

        [Column("thursday")]
        public bool Thursday { get; set; } = true;

        [Column("friday")]
        public bool Friday { get; set; } = true;

        [Column("saturday")]
        public bool Saturday { get; set; } = true;

        [Column("sunday")]
        public bool Sunday { get; set; } = true;
    }
}
