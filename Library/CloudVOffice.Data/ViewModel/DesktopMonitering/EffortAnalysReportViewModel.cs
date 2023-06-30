using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.DesktopMonitering
{
    public class EffortAnalysReportViewModel
    {
        public string EmployeeName { get; set; }
        public int  TotalNoOfDaysInMonth { get; set; }
        public int TotalNoOfWorkingDays { get; set; }  
        public double? EffortHourRequired { get; set; }
        public double EffortHours { get; set; }
        public double IdelHours { get; set; }
        public double ActualEffortHours { get; set; }
        public double? EffortPercentage { get; set; }

    }
}
