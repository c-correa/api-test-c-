using ApiTest.Src.Users;
using ApiTest.Src.Users.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController(ServiceUsers serviceUsers) : ControllerBase
    {
        private readonly ServiceUsers _serviceUsers = serviceUsers;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _serviceUsers.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _serviceUsers.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] User data)
        {
                var result = SafeExecutor.Execute(() => _serviceUsers.Add(data));
                return Ok(result);
        }
    }

}
