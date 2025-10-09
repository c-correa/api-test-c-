

using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Pets;

namespace ApiTest.Src.Pets.Services
{
    public class ServicesPet(ApplicationDbContext context): Service<PetModel>(context)
    { 
    }
}