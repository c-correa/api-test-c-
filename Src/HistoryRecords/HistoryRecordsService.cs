
using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.HistoryRecords.Models;

namespace ApiTest.Src.HistoryRecords.Service
{
    public class ServicesHistoryRecord(ApplicationDbContext context) : Service<HistoryRecord>(context)
    {
    }
}