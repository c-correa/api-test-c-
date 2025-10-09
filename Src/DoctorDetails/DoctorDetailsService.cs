
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.DoctorsDetails.Models;

namespace ApiTest.Src.DoctorsDetails.Service
{
    public class ServicesDoctorDetails(ApplicationDbContext context) : Service<DoctorDetails>(context)
    {
    }
}