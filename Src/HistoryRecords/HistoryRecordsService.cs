
using ApiTest.Data;
using ApiTest.Services;

namespace ApiTest.Src.HistoryRecords
{
    public class ServicesHistoryRecord(ApplicationDbContext context) : Service<HistoryRecordModel>(context)
    {
    }
}