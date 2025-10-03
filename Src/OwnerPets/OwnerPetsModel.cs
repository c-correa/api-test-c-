

using ApiTest.Src.Owners.Models;
using ApiTest.Src.Pets.Models;
using ApiTest.Utils;

namespace ApiTest.Src.OwnersPets.Models
{
    public class OwnersPet : BaseEntity
    {

        int PetId { get; set; }
        int OwnerId { get; set; }  

        List<Pet> Pet { get; set; }

        List<Owner> Owner { get; set; }

    }
}