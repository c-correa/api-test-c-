
using ApiTest.Src.Appointments;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Doctors
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentsController(ServicesAppointments servicesAppointments) : ControllerBase
    {
        private readonly ServicesAppointments _servicesAppointments = servicesAppointments;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesAppointments.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesAppointments.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] AppointmentsModel data)
        {
                var result = SafeExecutor.Execute(() => _servicesAppointments.Add(data));
                return Ok(result);
        }
    }

}
