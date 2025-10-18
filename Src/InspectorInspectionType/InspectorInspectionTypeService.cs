using ApiTest.Data;
using ApiTest.Src.Owners.Dto;
using AutoMapper;

namespace ApiTest.Src.InspectorInspectionType
{
    public class InspectorInspectionTypeServices(ApplicationDbContext context, IMapper mapper) : Service<InspectorInspectionTypeModel, CreateInspectorInspectionTypeDto, object>(context, mapper)
    {
        private readonly ApplicationDbContext __context = context;

    }
}
