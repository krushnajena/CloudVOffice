using SQLite;
using System;

namespace DesktopMonitoringSystem.Classes
{
    public class DMSActivityLog
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string LogType { get; set; }
        public int? DesktopLoginId { get; set; }
        public DateTime? LogDateTime { get; set; }
        public string ComputerName { get; set; }
        public string ProcessOrUrl { get; set; }
        public string AppOrWebPageName { get; set; }
        public string TypeOfApp { get; set; }
        public DateTime? SyncedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

        public string Action { get; set; }
        public string Source { get; set; }
        public string Folder { get; set; }
        public string FileName { get; set; }

        public string PrinterName { get; set; }
        public DateTime? Todatetime { get; set; }

        public int ServerLogId { get; set; }
        public bool IsSynced { get; set; }

    }
}
