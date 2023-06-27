
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMonitoringSystem.Models
{
    public class LoginSessionModel
    {
        public List<DesktopLoginsViewModel> data { get; set; }
    }
    public class DesktopLoginsViewModel
    {
        public Int64 DesktopLoginId { get; set; }
        public Int64 EmployeeId { get; set; }

        public DateTime? LoginDateTime { get; set; }
        public DateTime? LogOutDateTime { get; set; }

        public DateTime LogDate { get; set; }

        public string EmployeeName { get; set; }
        public string UserName { get; set; }
        public string ApplicantName { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public string Duration { get; set; }
        public string IdelDuration { get; set; }
    }

}
