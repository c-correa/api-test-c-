using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace test.Controllers 
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Stores>> Get()
        {
            Service servicio = new Service();
            List<Stores> record = await servicio.FindAll();
            return record;
        }
        
        [HttpGet("{id}")]
        public async Task<Stores> GetOne(int id)
        {
            Service servicio = new Service();
            Stores record = await servicio.FindOne(id); 
            return record;
        }
    }
}
