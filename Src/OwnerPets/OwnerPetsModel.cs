using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Owners;
using ApiTest.Src.Pets;
using ApiTest.Utils;

namespace ApiTest.Src.OwnerPets
{
    [Table("owners_pets")]
    public class OwnerPetsModel : BaseEntity
    {
        [Required, Column("owner_id"), NotNull]
        public int OwnerId { get; set; }

        [Required, Column("pet_id"), NotNull]
        public int PetId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public OwnerModel Owner { get; set; } = null!;

        [ForeignKey(nameof(PetId))]
        public PetModel Pet { get; set; } = null!;
    }
}
