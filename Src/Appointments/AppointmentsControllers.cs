
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Appointments
{
    [Route("api/appointments")]
    public class AppointmentsController(ServicesAppointments servicesAppointments) : BaseController<AppointmentsModel>(servicesAppointments)
    {
        private readonly ServicesAppointments _servicesAppointments = servicesAppointments;

    }

}
