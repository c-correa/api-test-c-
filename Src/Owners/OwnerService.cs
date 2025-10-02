
using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.Users
{
    public class ServiceUsers(ApplicationDbContext context) : Service<User>(context)
    {
    }
}