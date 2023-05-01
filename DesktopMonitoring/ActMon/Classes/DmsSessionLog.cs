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

    public class CreateDesktopLoginDTO
    {
        public int UserId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }

        public bool IsAutoLogedOut { get; set; }
        public bool IsActiveSession { get; set; }
        public DateTime? SyncedOn { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public int CreatedBy { get; set; }
        public int IdelTime { get; set; }
    }

    public class DesktopLogin
    {

        public int DesktopLoginId { get; set; }
        public int UserId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }
        public bool IsAutoLogedOut { get; set; }
        public bool IsActiveSession { get; set; }
        public DateTime? SyncedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        //public TimeSpan? IdelTime { get; set; }


    }
}
