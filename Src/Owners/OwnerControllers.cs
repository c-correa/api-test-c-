
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Owners
{
    [Route("api/owners")]
    public class OwnerController(ServicesOwner servicesOwner) : BaseController<OwnerModel>(servicesOwner)
    {
        private readonly ServicesOwner _servicesOwner = servicesOwner;

[HttpGet("{id}/pets")]
public async Task<IActionResult> GetOwnerWithPets(int id)
{
    var owner = await _servicesOwner.GetOwnerWithJoinAsync(id); // ✅ ahora sí espera la tarea

    if (owner == null)
        return NotFound(new { message = "Owner not found" });

    return Ok(owner);
}


            }

}
