namespace ApiTest.Src.Pets.Dto
{
public class CreatePetDto
{
    public string Name { get; set; } = default!;
    public string Breed { get; set; } = default!;
    public ESex Sexo { get; set; }
}

}
