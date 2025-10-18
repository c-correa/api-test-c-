
using ApiTest.Data;
using ApiTest.Src.Appointment.Dto;
using AutoMapper;

namespace ApiTest.Src.Appointment
{
    public class AppointmentServices(ApplicationDbContext context, IMapper mapper) : Service<AppointmentModel, CreateAppointmentDto, UpdateAppointmentDto>(context, mapper)
    {
    }
}