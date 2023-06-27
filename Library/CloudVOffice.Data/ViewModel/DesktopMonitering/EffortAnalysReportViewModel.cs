using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.DesktopMonitering
{
    public class EffortAnalysReportViewModel
    {
        public string EmployeeName { get; set; }
        public int  TotalNoOfDaysInMonth { get; set; }
        public int TotalNoOfWorkingDays { get; set; }  
        public double? TotalNoOfWorkingHours { get; set; }  
        public TimeSpan IdelHours { get; set; }
        public TimeSpan EffortHours { get; set; }
        public double? PercentageOfWorkDone { get; set; }

    }
}
