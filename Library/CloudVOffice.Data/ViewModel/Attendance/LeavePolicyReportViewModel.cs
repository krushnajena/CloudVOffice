using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.Attendance
{
	public class LeavePolicyReportViewModel
	{
        public int LeavePolicyId { get; set; }
        public string? LeavePeriodName { get; set; }
		public string? EmployeeGradeName { get; set; }
		public string? LeaveTypeName { get; set; }
		public int? NoOfLeaves { get; set; }
		public int? AllocationMode { get; set; }
		public List<LeavePolicyReportViewModel> Leaves { get; set; }
	}
}
