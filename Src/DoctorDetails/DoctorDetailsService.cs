
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.DoctorsDetails;

namespace ApiTest.Src.DoctorsDetails
{
    public class ServicesDoctorDetails(ApplicationDbContext context) : Service<DoctorDetailsModel>(context)
    {
    }
}