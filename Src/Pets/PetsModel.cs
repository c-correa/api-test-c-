

using ApiTest.Src.Owners.Models;
using ApiTest.Src.OwnersPets.Models;
using ApiTest.Utils;

enum EGender
{
    FEMALE,
    MALE
}

enum EType
{
    CANINO,
    FELINO
}

namespace ApiTest.Src.Pets.Models
{
    public class Pet : BaseEntity
    {
        string Name { get; set; }

        EGender Gender { get; set; }

        string Race { get; set; }

        EType Type { get; set; }

        List<Owner> Owners { get; set; } = [];

        List<OwnersPet> OwnersPets { get; set; } = [];


    }
}