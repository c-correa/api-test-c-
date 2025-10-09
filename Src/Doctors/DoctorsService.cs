
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Doctors;

namespace ApiTest.Src.Doctors
{
    public class ServicesDoctor(ApplicationDbContext context) : Service<DoctorModel>(context)
    {
    }
}