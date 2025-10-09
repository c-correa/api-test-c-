
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Doctors.Models;

namespace ApiTest.Src.Doctors.Service
{
    public class ServicesDoctor(ApplicationDbContext context) : Service<Doctor>(context)
    {
    }
}