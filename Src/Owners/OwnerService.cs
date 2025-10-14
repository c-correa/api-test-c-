using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Owners.Dto;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Src.Owners
{
    public class ServicesOwner : Service<OwnerModel>
    {
        private readonly ApplicationDbContext _context;

        public ServicesOwner(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<OwnerWithPetsViewModelDto?> GetOwnerWithJoinAsync(int id)
        {
            var owner = await _context.Owners
                .Include(o => o.OwnerPets)
                    .ThenInclude(op => op.Pet)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (owner == null) return null;

            var pets = owner.OwnerPets
                .Where(op => op.Pet != null)
                .Select(op => new PetViewModelDto(
                    op.Pet.Id,
                    op.Pet.Name
                ))
                .ToList();

            return new OwnerWithPetsViewModelDto(owner.Id, pets);
        }
    }
}
