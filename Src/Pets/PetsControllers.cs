

using ApiTest.Src.Pets.Services;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Src.Pets
{
    [ApiController]
    [Route("api/pets")]
    public class PetsController(ServicesPet servicesPet) : ControllerBase
    {
        private readonly ServicesPet _servicesOwner = servicesPet;

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
        public IActionResult Create([FromBody] PetModel data)
        {
            var result = SafeExecutor.Execute(() => _servicesOwner.Add(data));
            return Ok(result);
        }
    }

}
