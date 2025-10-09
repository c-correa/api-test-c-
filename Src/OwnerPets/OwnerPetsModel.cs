

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Owners;
using ApiTest.Src.Pets;
using ApiTest.Utils;

namespace ApiTest.Src.OwnerPets
{
    public class OwnerPetsModel : BaseEntity
    {

        [Required]
        [Column("pet_id")]
        [NotNull]
        int PetId { get; set; }
        
        [Required]
        [Column("owner_id")]
        [NotNull]
        int OwnerId { get; set; }  

        PetModel Pet { get; set; }

        OwnerModel Owner { get; set; }

    }
}