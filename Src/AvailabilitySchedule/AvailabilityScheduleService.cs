
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.AvailabilitySchedule;

namespace ApiTest.Src.AvailabilitySchedules
{
    public class ServicesAvailabilitySchedule(ApplicationDbContext context) : Service<AvailabilityScheduleModel>(context)
    {
    }
}