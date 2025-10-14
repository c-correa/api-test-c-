

namespace ApiTest.Src.Owners.Dto;
public record OwnerWithPetsViewModelDto(
    int Id,
    List<PetViewModelDto> Pets
);

public record PetViewModelDto(
    int Id,
    string Name
);
