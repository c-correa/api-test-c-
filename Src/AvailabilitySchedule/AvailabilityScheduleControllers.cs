
using ApiTest.Src.AvailabilitySchedule;
using ApiTest.Src.AvailabilitySchedules;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.AvailabilitySchedule
{
    [Route("api/availability-schedule")]
    public class AvailabilityScheduleController(ServicesAvailabilitySchedule servicesAvailabilitySchedule) : BaseController<AvailabilityScheduleModel>(servicesAvailabilitySchedule)
    {
        private readonly ServicesAvailabilitySchedule _servicesAvailabilitySchedule = servicesAvailabilitySchedule;

    }

}
