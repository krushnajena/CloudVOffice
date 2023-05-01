using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.DesktopMonitoring
{
    public class DesktopLoginDTO
    {
        public Int64 DesktopLoginId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }
        public bool IsAutoLogedOut { get; set; }
        public bool IsActiveSession { get; set; }
        public DateTime? SyncedOn { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
