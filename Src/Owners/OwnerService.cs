
using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.Owners
{
    public class ServicesOwner(ApplicationDbContext context) : Service<OwnerModel>(context)
    {
    }
}