using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace test.Controllers 
{
    [ApiController]
    [Route("api/users")]
    public class UsersController  : ControllerBase 
    {
        [HttpGet]
        public async Task<List<User>> Get()
        {
            Service servicio = new Service();
            List<User> record = await servicio.Hola(); 
            return record;
        }
    }
}
