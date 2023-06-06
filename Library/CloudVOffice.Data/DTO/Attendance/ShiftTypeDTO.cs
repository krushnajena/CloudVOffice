using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
	public class ShiftTypeDTO
	{
		public int? ShiftTypeId { get; set; }
		public string ShiftTypeName { get; set; }
		public TimeSpan? StartTime { get; set; }
		public TimeSpan? EndTime { get; set; }
		public int? LateEntryGracePeriodInMinutes { get; set; }
		public int? EarlyExitGracePeriodInMinutes { get; set; }
		public double? ThresholdforHalfDayInHours { get; set; }
		public double? ThresholdforAbsentInHours { get; set; }
		public int CreatedBy { get; set; }
	}
}
