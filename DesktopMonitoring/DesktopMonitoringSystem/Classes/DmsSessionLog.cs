using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace DesktopMonitoringSystem.Classes
{
    public class DmsSessionLog
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MachineName { get; set; }
        public string IpAddress { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public Int64? IdelTime { get; set; }
        public bool IsSynced { get; set; }
        public int ServerSessionId { get; set; }
        public bool IsAutoLogOut { get; set; }
    }
}
