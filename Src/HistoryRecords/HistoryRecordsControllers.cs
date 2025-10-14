
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.HistoryRecords
{
    [Route("api/history_record")]
    public class HistoryRecordController(ServicesHistoryRecord servicesHistoryRecord) : BaseController<HistoryRecordModel>(servicesHistoryRecord)
    {
        private readonly ServicesHistoryRecord _servicesHistoryRecord = servicesHistoryRecord;

    }

}
