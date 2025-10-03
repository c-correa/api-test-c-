using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.OwnersPets.Models;

namespace ApiTest.Src.OwnersPets.Services
{
    public class ServicesOwnersPets(ApplicationDbContext context) : Service<OwnersPet>(context)
    {
    }
}