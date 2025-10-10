using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Src.DoctorDetails
{
    [Route("api/doctor_details")]
    public class DoctorDetailsController(ServicesDoctorDetails customService) : BaseController<DoctorDetailsModel>(customService)
    {
        private readonly ServicesDoctorDetails _customService = customService;
    }
}
