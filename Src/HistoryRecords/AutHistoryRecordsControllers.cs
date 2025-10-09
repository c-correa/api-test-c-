
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.HistoryRecords
{
    [ApiController]
    [Route("api/history_record")]
    public class HistoryRecordController(ServicesHistoryRecord servicesHistoryRecord) : ControllerBase
    {
        private readonly ServicesHistoryRecord _servicesHistoryRecord = servicesHistoryRecord;

        [HttpGet]
        public IActionResult Get()
        {
            var result = SafeExecutor.Execute(() => _servicesHistoryRecord.GetAll());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            var result = SafeExecutor.Execute(() => _servicesHistoryRecord.GetById(id));
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] HistoryRecordModel data)
        {
                var result = SafeExecutor.Execute(() => _servicesHistoryRecord.Add(data));
                return Ok(result);
        }
    }

}
