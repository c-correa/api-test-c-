
using ApiTest.Src.Doctors.Models;
using ApiTest.Src.Doctors.Service;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Doctors.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController(ServicesDoctor servicesDoctor) : ControllerBase
    {
        private readonly ServicesDoctor _servicesDoctor = servicesDoctor;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesDoctor.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesDoctor.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] Doctor data)
        {
                var result = SafeExecutor.Execute(() => _servicesDoctor.Add(data));
                return Ok(result);
        }
    }

}
