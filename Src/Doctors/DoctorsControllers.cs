


using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Doctors
{
    [Route("api/doctors")]
    public class DoctorController(ServicesDoctor servicesDoctor) : BaseController<DoctorModel>(servicesDoctor)
    {
        private readonly ServicesDoctor _servicesDoctor = servicesDoctor;

    }

}
