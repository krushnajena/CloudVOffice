using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class ShiftType : IAuditEntity, ISoftDeletedEntity
    {
        public int ShiftTypeId { get; set; }
        
        public string ShiftTypeName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? LateEntryGracePeriodInMinutes { get; set; }
        public int? EarlyExitGracePeriodInMinutes { get; set; }
        public double? ThresholdforHalfDayInHours { get; set; }
        public double? ThresholdforAbsentInHours { get; set; }
        public bool IsDefaultShift { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }



    }
}
