

using ApiTest.Src.OwnerPets;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Src.OwnersPets
{
    [Route("api/owner-pets")]
    public class OwnersPetsController(ServicesOwnersPets servicesOwnersPets) : BaseController<OwnerPetsModel>(servicesOwnersPets)
    {
        private readonly ServicesOwnersPets _servicesOwnersPets = servicesOwnersPets;

    }

}
