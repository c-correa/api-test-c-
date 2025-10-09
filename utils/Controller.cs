using Microsoft.AspNetCore.Mvc;
using ApiTest.Services;
using ApiTest.Utils;

namespace ApiTest.Utils.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class, IBaseEntity
    {
        private readonly service<T> _service;

        public BaseController(Service<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _service.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _service.GetById(id));
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] T data)
        {
            var result = SafeExecutor.Execute(() => _service.Add(data));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] T data)
        {
            SafeExecutor.Execute(() =>
            {
                _service.Update(data);
                return true;
            });
            return Ok(new { Message = "Record updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SafeExecutor.Execute(() =>
            {
                var entity = _service.GetById(id);
                if (entity == null)
                    throw new ArgumentException("Entity not found");

                _service.Delete(entity);
                return true;
            });
            return Ok(new { Message = "Record deleted successfully" });
        }
    }
}
