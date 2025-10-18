using ApiTest.Data;
using ApiTest.Src.InspectionType.Dto;
using AutoMapper;

namespace ApiTest.Src.InspectionType
{
    public class InspectionTypeServices(ApplicationDbContext context, IMapper mapper) : Service<InspectionTypeModel, CreateInspectionTypeDto, UpdateInspectionTypeDto>(context, mapper)
    {
        private readonly ApplicationDbContext _context = context;

        
    }
}
