using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class LeavePeriodDTO
    {
        public int LeavePeriodId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
