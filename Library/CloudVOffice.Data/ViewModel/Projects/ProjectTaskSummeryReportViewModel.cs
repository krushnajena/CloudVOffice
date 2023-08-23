using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.Projects
{
    public class ProjectTaskSummeryReportViewModel
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Open { get; set; }
        public string Working { get; set; }
        public string PendingReview { get; set; }
        public string Overdue { get; set; }
        public string Completed { get; set; }
        public string Canceled { get; set; }    
      
        public List<ProjectTaskSummeryReportViewModel> Employees { get; set; }
    }
    public class ProjectEmployeeWiseEffortReportViewModel
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string PlannedEffortHours { get; set; }
        public string UsedEffortHours { get; set; }
        public double EffortPercentage { get; set; }
        public List<ProjectEmployeeWiseEffortReportViewModel> Employees { get; set; }
    }

}
