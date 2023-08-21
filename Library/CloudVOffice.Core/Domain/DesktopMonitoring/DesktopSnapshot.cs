using Newtonsoft.Json;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class DesktopSnapshot : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 DesktopSnapshotId { get; set; }
        public Int64? DesktopActivityLogId { get; set; }
        public Int64? DesktopLoginId { get; set; }
        public Int64? EmployeeId { get; set; }
        public string? LogType { get; set; }
        public string? SnapShot { get; set; }
        public DateTime? SnapshotDateTime { get; set; }
        public Double? FileSize { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [JsonIgnore]
        public DesktopActivityLog DesktopActivityLog { get; set; }
    }
}
