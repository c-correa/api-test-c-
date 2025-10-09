
using ApiTest.Src.AvailabilitySchedule;
using ApiTest.Src.AvailabilitySchedules;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Doctors
{
    [ApiController]
    [Route("api/AvailabilitySchedule")]
    public class AvailabilityScheduleController(ServicesAvailabilitySchedule servicesAvailabilitySchedule) : ControllerBase
    {
        private readonly ServicesAvailabilitySchedule _servicesAvailabilitySchedule = servicesAvailabilitySchedule;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesAvailabilitySchedule.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesAvailabilitySchedule.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] AvailabilityScheduleModel data)
        {
                var result = SafeExecutor.Execute(() => _servicesAvailabilitySchedule.Add(data));
                return Ok(result);
        }
    }

}
