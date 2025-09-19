using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace test.Controllers 
{
    [ApiController]
    [Route("api/users")]
    public class UsersController  : ControllerBase 
    {
            private readonly Service _db;

        [HttpGet]
        public void  Get()
        {
        Service servicio = new Service();
        servicio.Hola();

        Console.ReadLine();
        }

        [HttpPost()]
        public IActionResult Create([FromBody] User data)
        {
            return Ok(new { message = "API funcionando" });
        }

        [HttpPatch("{id}")]
        public IActionResult Update()
        {
            return Ok(new { message = "API funcionando" });
        }

        [HttpDelete("{id}")]
        public IActionResult Remove()
        {
            return Ok(new { message = "API funcionando" });
        }
    }
}
