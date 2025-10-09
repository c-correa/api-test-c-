using System.ComponentModel.DataAnnotations.Schema;
using ApiTest.Src.OwnersPets.Models;
using ApiTest.Utils;

namespace ApiTest.Src.HistoryRecords.Models
{
    [Table("history_record")]
    public class HistoryRecord : BaseEntity
    {

        List<OwnersPet> OwnersPets { get; set; } = [];
    }
}
