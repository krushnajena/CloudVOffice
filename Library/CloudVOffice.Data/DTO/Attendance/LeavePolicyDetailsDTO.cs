using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
	public class LeavePolicyDetailsDTO
	{
		public int? LeavePolicyDetailsId { get; set; }
		public int LeavePolicyId { get; set; }
		public int LeaveTypeId { get; set; }
		public int NoOfLeaves { get; set; }
		public int AllocationMode { get; set; } //1=Annual ,2=Monthly
		public Int64 CreatedBy { get; set; }
	}
}
