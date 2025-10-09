using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.OwnerPets
{
    public class ServicesOwnersPets(ApplicationDbContext context) : Service<OwnerPetsModel>(context)
    {
    }
}