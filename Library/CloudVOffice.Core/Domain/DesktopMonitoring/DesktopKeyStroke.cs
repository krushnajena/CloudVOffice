using System.Text.Json.Serialization;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class DesktopKeyStroke : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 DesktopKeyStrokeId { get; set; }
        public string LogType { get; set; }
        public Int64? DesktopActivityLogId { get; set; }
        public string Keystrokes { get; set; }
        public DateTime? KeyStrokeDateTime { get; set; }

        public DateTime? SyncedOn { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [JsonIgnore]
        public DesktopActivityLog DesktopActivityLog { get; set; }
    }
}
