using CloudVOffice.Core.Domain.HR.Emp;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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




        [NotMapped]
        public string ForDate
        {
            get
            {



                return DateTime.Parse(LogDateTime.ToString()).ToString("dd-MMM-yyyy");


            }
        }

        [NotMapped]
        public string Duration
        {
            get
            {
                var dateOne = LogDateTime;
                var dateTwo = Todatetime;
                if (dateOne != null)
                {
                    var diff = DateTime.Parse(dateTwo.ToString()).Subtract(DateTime.Parse(dateOne.ToString()));
                    return String.Format("{0}:{1}:{2}", diff.Hours, diff.Minutes, diff.Seconds);
                }
                else
                {
                    return "00:00:00";
                }

            }
        }

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
