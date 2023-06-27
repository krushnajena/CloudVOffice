using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class DesktopLogin : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 DesktopLoginId { get;set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }
        public bool IsAutoLogedOut { get; set; }
        public bool IsActiveSession { get; set; }

        public TimeSpan? IdelTime { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public DateTime? SyncedOn { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [NotMapped]
        public string Duration
        {
            get
            {
                var dateOne = LoginDateTime;
                var dateTwo = LogOutDateTime;
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
        [NotMapped]
        public string ForDate
        {
            get
            {



                return DateTime.Parse(LoginDateTime.ToString()).ToString("dd-MMM-yyyy");


            }
        }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

    }
}
