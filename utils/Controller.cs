using Microsoft.AspNetCore.Mvc;
using ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Utils
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, C, U>(Service<T, C, U> service) : ControllerBase
        where T : class, IBaseEntity
        where U : class?
    {
        protected readonly Service<T, C, U> _service = service;

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
        public virtual IActionResult Create([FromBody] C dto)
        {
            try
            {
                // Llama al servicio genérico para crear el registro
                var result = _service.Add(dto);

                // Devuelve respuesta OK con mensaje
                return Ok(new { Message = "Record created successfully", Data = result });
            }
            catch (DbUpdateException dbEx)
            {
                // Captura errores de EF como violación de unique constraint
                return BadRequest(new 
                { 
                    Message = "Database update error", 
                    Detail = dbEx.InnerException?.Message 
                });
            }
            catch (Exception ex)
            {
                // Otros errores
                return StatusCode(500, new { Message = ex.Message });
            }
        }


        [HttpPut("{id}")]
        public virtual IActionResult Update(int id, [FromBody] U? dto)
        {
            SafeExecutor.Execute(() =>
            {
                _service.Update(id, dto);
                return true;
            });

            return Ok(new { Message = "Record updated successfully" });
        }

        // [HttpDelete("{id}")]
        // public virtual IActionResult Delete(int id)
        // {
        //     SafeExecutor.Execute(() =>
        //     {
        //         var entity = _service.GetById(id);
        //         if (entity == null)
        //             throw new ArgumentException("Entity not found");

        //         _service.Delete(entity);
        //         return true;
        //     });

        //     return Ok(new { Message = "Record deleted successfully" });
        // }
    }
}
