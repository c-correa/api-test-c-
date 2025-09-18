using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace test.Controllers 
{
    [ApiController]
    [Route("api/users")]
    public class UsersController  : ControllerBase 
    {
            private readonly PostgresDb _db;

        [HttpGet]
        public User[]  Get()
        {
            
            return Ok(new { message = "API funcionando" });
        }

        [HttpGet("{id}")]
        public User FindOne()
        {
            return Ok(new { message = "API funcionando" });
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
