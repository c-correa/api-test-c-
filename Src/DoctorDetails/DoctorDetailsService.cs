using ApiTest.Services;
using ApiTest.Data;

namespace ApiTest.Src.DoctorDetails
{
    public class ServicesDoctorDetails(ApplicationDbContext context) : Service<DoctorDetailsModel>(context)
    {
    }
}
