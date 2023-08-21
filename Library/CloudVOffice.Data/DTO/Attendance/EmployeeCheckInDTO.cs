using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class EmployeeCheckInDTO
    {
        public Int64? EmployeeCheckInId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? ForDate { get; set; }
        public int LogType { get; set; } // 1=In , 2= Out
        public int? DeviceId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
