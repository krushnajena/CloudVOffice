using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
	public class EmployeeAttendanceDTO
	{
		public Int64? EmployeeAttendanceId { get; set; }
		public Int64 EmployeeId { get; set; }
		public DateTime AttendanceDate { get; set; }
		public int Status { get; set; } //1-Present,2-Absent,3- Leave,4- Halfday Leave,5- Work from Home
		public bool IsLateEntry { get; set; }
		public bool IsEarlyExit { get; set; }

		public Int64 CreatedBy { get; set; }
	}
}
