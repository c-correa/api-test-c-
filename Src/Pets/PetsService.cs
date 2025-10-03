

using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Pets.Models;

namespace ApiTest.Src.Pets.Services
{
    public class ServicesPet(ApplicationDbContext context): Service<Pet>(context)
    { 
    }
}