using ApiTest.Data;
using ApiTest.Src.OwnerPets;
using ApiTest.Src.OwnerPets.Dto;
using ApiTest.Src.Owners;
using ApiTest.Src.Pets.Services;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Src.Pets
{
    [Route("api/pets")]
    [ApiController]
    public class PetsController : BaseController<PetModel>
    {
        private readonly ServicesPet _servicesPet;
        private readonly ServicesOwner _servicesOwner;
        private readonly ServicesOwnersPets _servicesOwnerPets;
        private readonly ApplicationDbContext _context;

        public PetsController(
            ServicesPet servicesPet,
            ServicesOwner servicesOwner,
            ServicesOwnersPets servicesOwnerPets,
            ApplicationDbContext context
        ) : base(servicesPet)
        {
            _servicesPet = servicesPet;
            _servicesOwner = servicesOwner;
            _servicesOwnerPets = servicesOwnerPets;
            _context = context;
        }

        [HttpPost("create-with-owner")]
        public IActionResult CreatePetWithOwner([FromBody] CreatePetWithOwnerDto dto)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                // 1️⃣ Crear el dueño
                var owner = new OwnerModel
                {
                    FirstName = dto.Owner.FirstName,
                    LastName = dto.Owner.LastName,
                    Phone = dto.Owner.Phone,
                    Email = dto.Owner.Email,
                    Password = dto.Owner.Password,
                    IsActive = true
                };

                _servicesOwner.Add(owner);

                // 2️⃣ Crear la mascota
                var pet = new PetModel
                {
                    Name = dto.Pet.Name,
                    Breed = dto.Pet.Breed,
                    Sexo = dto.Pet.Sexo
                };

                _servicesPet.Add(pet);

                // 3️⃣ Relacionar dueño ↔ mascota
                var ownerPet = new OwnerPetsModel
                {
                    OwnerId = owner.Id,
                    PetId = pet.Id
                };

                _servicesOwnerPets.Add(ownerPet);

                transaction.Commit();

                return Ok(new
                {
                    message = "Mascota y dueño creados correctamente",
                    owner,
                    pet
                });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return StatusCode(500, new
                {
                    message = "Error al crear mascota y dueño",
                    error = ex.Message
                });
            }
        }
    }
}
