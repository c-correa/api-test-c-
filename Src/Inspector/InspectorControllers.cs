
using ApiTest.Src.Inspector;
using ApiTest.Src.Owners.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Inspector
{
    [Route("api/inspector")]
    public class InspectorController(InspectorServices inspectorServices) : BaseController<InspectorModel, CreateInspectorDto, UpdateInspectorDto>(inspectorServices)
    {
        private readonly InspectorServices _inspectorServices = inspectorServices;
        [HttpPost("create")]
        public IActionResult CreateInspector([FromBody] CreateInspectorDto dto)
        {
            var result = SafeExecutor.Execute(() => _inspectorServices.CreateInspector(dto));
            return Ok(result);
        }
        [HttpGet("by-inspection-type/{inspectionTypeId?}")]
        public IActionResult GetInspectorsByInspectionType(int? inspectionTypeId = null)
        {
            var result = SafeExecutor.Execute(() => _inspectorServices.GetInspectors(inspectionTypeId));
            return Ok(result);
        }


    }

}
