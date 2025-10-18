
using ApiTest.Src.InspectorInspectionType;
using ApiTest.Src.Owners.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Owners
{
    [Route("api/inspector-inspection-type")]
    public class InspectorInspectionTypeController(InspectorInspectionTypeServices inspectorInspectionTypeServices) : BaseController<InspectorInspectionTypeModel, CreateInspectorInspectionTypeDto, object>(inspectorInspectionTypeServices)
    {
        private readonly InspectorInspectionTypeServices _inspectorInspectionTypeServices = inspectorInspectionTypeServices;
    }

}
