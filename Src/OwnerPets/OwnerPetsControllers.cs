

using ApiTest.Src.OwnerPets;
using ApiTest.Src.OwnersPets;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Src.OwnersPets
{
    [ApiController]
    [Route("api/owner-pets")]
    public class OwnersPetsController(ServicesOwnersPets servicesOwnersPets) : ControllerBase
    {
        private readonly ServicesOwnersPets _servicesOwnersPets = servicesOwnersPets;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesOwnersPets.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesOwnersPets.GetById(id));
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] OwnerPetsModel data)
        {
            var result = SafeExecutor.Execute(() => _servicesOwnersPets.Add(data));
            return Ok(result);
        }
    }

}
