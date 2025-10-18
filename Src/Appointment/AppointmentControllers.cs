
using ApiTest.Src.Appointment.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Appointment
{
    [Route("api/appointments")]
    public class AppointmentController(AppointmentServices appointmentServices) : BaseController<AppointmentModel, CreateAppointmentDto, UpdateAppointmentDto>(appointmentServices)
    {
        private readonly AppointmentServices _appointmentServices = appointmentServices;

    }

}
