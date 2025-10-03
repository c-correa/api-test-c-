
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Owners.Models;

namespace ApiTest.Src.Owners.Service
{
    public class ServicesOwner(ApplicationDbContext context) : Service<Owner>(context)
    {
    }
}