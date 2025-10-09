using System.ComponentModel.DataAnnotations.Schema;
using ApiTest.Src.Appointments;
using ApiTest.Src.Pets;
using ApiTest.Utils;

namespace ApiTest.Src.HistoryRecords
{
    [Table("history_record")]
    public class HistoryRecordModel : BaseEntity
    {

                public virtual AppointmentsModel AppointmentsModel { get; set; } = null!;


    }
}
