using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class DesktopActivityLog : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 DesktopActivityLogId { get; set; }
        public Int64 EmployeeId { get; set; }
        public string LogType { get; set; }
        public Int64? DesktopLoginId { get; set; }
        public DateTime? LogDateTime { get; set; }
        public string? ComputerName { get; set; }
        public string? ProcessOrUrl { get; set; }
        public string? AppOrWebPageName { get; set; }
        public string? TypeOfApp { get; set; }
        public DateTime? SyncedOn { get; set; }
    

        public string? Action { get; set; }
        public string? Source { get; set; }
        public string? Folder { get; set; }
        public string? FileName { get; set; }

        public string? PrinterName { get; set; }
        public DateTime? Todatetime { get; set; }

      

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        public List<DesktopSnapshot> DesktopSnapshots { get; set; }
        public List<DesktopKeyStroke> DesktopKeyStrokes { get; set; }

        [JsonIgnore]
        public Employee Employee { get; set; }

    }
}
