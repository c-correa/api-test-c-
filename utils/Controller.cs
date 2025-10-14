using Microsoft.AspNetCore.Mvc;
using ApiTest.Services;
using ApiTest.Utils;

namespace ApiTest.Utils
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T>(Service<T> service) : ControllerBase where T : class, IBaseEntity
    {
        protected readonly Service<T> _service = service;

        [HttpGet]
        public virtual IActionResult GetAll()
        {
            var result = SafeExecutor.Execute(() => _service.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetById(int id)
        {
            var result = SafeExecutor.Execute(() => _service.GetById(id));
            return Ok(result);
        }

        [HttpPost]
        public virtual IActionResult Create([FromBody] T entity)
        {
            var result = SafeExecutor.Execute(() => _service.Add(entity));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public virtual IActionResult Update(int id, [FromBody] T entity)
        {
            SafeExecutor.Execute(() =>
            {
                _service.Update(entity);
                return true;
            });

            return Ok(new { Message = "Record updated successfully" });
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
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
