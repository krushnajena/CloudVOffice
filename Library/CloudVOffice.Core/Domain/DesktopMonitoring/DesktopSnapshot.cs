using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class DesktopSnapshot : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 DesktopSnapshotId { get; set; }
        public string LogType { get; set; }
        public int? DesktopActivityLogId { get; set; }
        public string SnapShot { get; set; }
        public DateTime? SnapshotDateTime { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [JsonIgnore]
        public DesktopActivityLog DesktopActivityLog { get; set; }
    }
}
