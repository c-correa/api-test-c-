
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Owners
{
    [ApiController]
    [Route("api/owners")]
    public class OwnerController(ServicesOwner servicesOwner) : ControllerBase
    {
        private readonly ServicesOwner _servicesOwner = servicesOwner;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesOwner.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesOwner.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] OwnerModel data)
        {
                var result = SafeExecutor.Execute(() => _servicesOwner.Add(data));
                return Ok(result);
        }
    }

}
