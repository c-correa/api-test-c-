using ApiTest.Data;
using ApiTest.Src.Vehicle.Dto;
using ApiTest.Utils;
using AutoMapper;

namespace ApiTest.Src.Vehicle
{
public class VehicleServices : Service<VehicleModel, CreateVehicleDto, UpdateVehicleDto>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public VehicleServices(ApplicationDbContext context, IMapper mapper) 
        : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

        public OkResult CreateVehicle(CreateVehicleDto dto)
        {
            var existing = _context.Vehicle
                                   .FirstOrDefault(v => v.LicensePlate == dto.LicensePlate);
            if (existing != null)
                throw new ArgumentException("Vehicle with the same license plate already exists.");

            var entity = _mapper.Map<VehicleModel>(dto);

            _context.Vehicle.Add(entity);
            _context.SaveChanges();

            return new OkResult { Ok = true };
        }
        public VehicleModel? GetByLicensePlate(string licensePlate)
        {
            var existing = _context.Vehicle
                                   .FirstOrDefault(v => v.LicensePlate == licensePlate) ?? throw new ArgumentException("No vehicle found with the given license plate.");
            return existing;

        }
        
        public ICollection<VehicleModel> GetVehiclesByCustomer(int idCustomer)
        {
            var vehicles = _context.Vehicle
                                .Where(v => v.IdCustomer == idCustomer)
                                .ToList(); // devuelve una lista

            if (!vehicles.Any())
                throw new ArgumentException("No vehicles found for the given customer.");

            return vehicles;
        }
    }
}
