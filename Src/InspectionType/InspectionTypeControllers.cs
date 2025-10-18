
using ApiTest.Src.InspectionType.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.InspectionType
{
    [Route("api/inspection-type")]
    public class InspectionTypeController(InspectionTypeServices inspectionTypeServices) : BaseController<InspectionTypeModel, CreateInspectionTypeDto, UpdateInspectionTypeDto>(inspectionTypeServices)
    {
        private readonly InspectionTypeServices _inspectionTypeServices = inspectionTypeServices;

    }

}
