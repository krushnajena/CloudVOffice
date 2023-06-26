using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class DesktopLoginDTO
    {
    
        public Int64 EmployeeId { get; set; }
        public DateTime? LoginDateTime { get; set; }

        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public DateTime? SyncedOn { get; set; }
        public Int64 CreatedBy { get; set; }
    }
    public class DesktopLoginFilterDTO
    {
        public Int64? EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
    public class DesktopLoginIdelTimeUpdateDTO
    {
        public Int64 DesktopLoginId { get; set; }
        public TimeSpan? IdelTime { get; set; }
    }
    public class SuspesiosActivityLogDTO
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? Duration { get; set; }
        public Int64? EmployeeId { get; set; }
    }
}
