

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
    [Table("pets")]
    public class PetModel : BaseEntity
    {
        [Required, Column("name"), NotNull]
        public required string Name { get; set; }

        [Required, Column("breed"), NotNull]  // <-- "breed" (no "bred")
        public required string Breed { get; set; }

        [Required, Column("sex"), NotNull]
        public required ESex Sexo { get; set; }

        // Relación muchos a muchos (vía tabla intermedia)
        public ICollection<OwnerPetsModel> OwnerPets { get; set; } = new List<OwnerPetsModel>();
    }
}
