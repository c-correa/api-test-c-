
using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.Appointments
{
    public class ServicesAppointments(ApplicationDbContext context) : Service<AppointmentsModel>(context)
    {
    }
}