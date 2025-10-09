

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Owners.Models;
using ApiTest.Src.Pets.Models;
using ApiTest.Utils;

namespace ApiTest.Src.OwnersPets.Models
{
    public class OwnersPet : BaseEntity
    {

        [Required]
        [Column("pet_id")]
        [NotNull]
        int PetId { get; set; }
        
        [Required]
        [Column("owner_id")]
        [NotNull]
        int OwnerId { get; set; }  

        List<Pet> Pet { get; set; }

        List<Owner> Owner { get; set; }

    }
}