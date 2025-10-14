using ApiTest.Data;
using ApiTest.Services;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Src.OwnerPets
{
    public class ServicesOwnersPets : Service<OwnerPetsModel>
    {
        private readonly ApplicationDbContext _context;

        public ServicesOwnersPets(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OwnerPetsModel>> GetAllWithRelationsAsync()
        {
            return await _context.OwnersPets
                .Include(op => op.Owner)
                .Include(op => op.Pet)
                .ToListAsync();
        }
    }
}
