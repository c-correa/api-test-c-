

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.HistoryRecords;
using ApiTest.Src.OwnerPets;
using ApiTest.Src.Owners;
using ApiTest.Utils;


public enum ESex
{
    Male,
    Female,
    Unknown
}

namespace ApiTest.Src.Pets
{
    public class PetModel : BaseEntity
    {
        [Required]
        [Column("name")]
        [NotNull]
        public required string Name { get; set; }

        [Required]
        [Column("bred")]
        [NotNull]
        public required string Breed { get; set; }

        [Required]
        [Column("sexo")]
        [NotNull]
        public required ESex Sexo { get; set; }

        ICollection<OwnerPetsModel> OwnersPets { get; set; } = new List<OwnerPetsModel>();


        [Required]
        [Column("history_record_id")]
        [NotNull]
        int HistoryRecordId { get; set; }  

        HistoryRecordModel HistoryRecord { get; set; }


    }
}