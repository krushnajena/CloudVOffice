using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class HolidayDays : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 HolidayDaysId { get; set; }
        public int? HolidayId { get; set; }
        public DateTime? ForDate { get; set; }
        public string Description { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("HolidayId")]
        public Holiday Holiday { get; set; }
    }
}
