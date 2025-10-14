
using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.Doctors
{
    public class ServicesDoctor(ApplicationDbContext context) : Service<DoctorModel>(context)
    {
    }
}