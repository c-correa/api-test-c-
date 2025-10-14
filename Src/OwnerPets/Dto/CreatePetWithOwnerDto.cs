using ApiTest.Src.Owners.Dto;
using ApiTest.Src.Pets.Dto;

namespace ApiTest.Src.OwnerPets.Dto
{

public class CreatePetWithOwnerDto
{
    public CreatePetDto Pet { get; set; } = default!;
    public CreateOwnerDto Owner { get; set; } = default!;
}
}
