using SQLite;
using System;
namespace DesktopMonitoringSystem.Classes
{
    public class DMSScreenShotLog
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string LogType { get; set; }
        public int? DmsActivityLogId { get; set; }
        public string SnapShot { get; set; }
        public DateTime? SnapshotDateTime { get; set; }

        public DateTime? SyncedOn { get; set; }
        public bool IsSynced { get; set; }
        public bool IsImageUploaded { get; set; }
        public string ServerImageName { get; set; }
    }
}
