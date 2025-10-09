
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.DoctorsDetails
{
    [ApiController]
    [Route("api/doctor_details")]
    public class DoctorDetailsController(ServicesDoctorDetails servicesDoctorDetails) : ControllerBase
    {
        private readonly ServicesDoctorDetails _servicesDoctorDetails = servicesDoctorDetails;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesDoctorDetails.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesDoctorDetails.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] DoctorDetailsModel data)
        {
                var result = SafeExecutor.Execute(() => _servicesDoctorDetails.Add(data));
                return Ok(result);
        }
    }

}
