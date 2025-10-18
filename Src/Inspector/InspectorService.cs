using ApiTest.Data;
using ApiTest.Src.Owners.Dto;
using ApiTest.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Src.Inspector
{
    public class InspectorServices(ApplicationDbContext context, IMapper mapper) : Service<InspectorModel,CreateInspectorDto, UpdateInspectorDto>(context, mapper)
    {
        private readonly ApplicationDbContext _context = context;

         public OkResult CreateInspector(CreateInspectorDto dto)
        {
            var existing = _context.Inspectors
                                .FirstOrDefault(i => i.DocumentNumber == dto.DocumentNumber);
            if (existing != null)
                throw new ArgumentException("Inspector with the same document number already exists.");

            var entity = mapper.Map<InspectorModel>(dto);

            entity.Status ??= "active";  // inicializa status si es null

            _context.Inspectors.Add(entity);
            _context.SaveChanges();

            return new OkResult { Ok = true };
        }


public IEnumerable<InspectorModel> GetInspectors(int? inspectionTypeId = null)
{
    var query = _context.Inspectors
                        .Include(i => i.InspectorInspectionTypes)
                            .ThenInclude(iit => iit.InspectionType)
                        .AsQueryable();

    if (inspectionTypeId.HasValue)
    {
        query = query.Where(i =>
            i.InspectorInspectionTypes != null &&
            i.InspectorInspectionTypes.Any(iit => iit.IdInspectionType == inspectionTypeId.Value)
        );
    }

    return query.ToList();
}
    }
}
