using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Attendance
{
	public class AttendanceDevice : IAuditEntity, ISoftDeletedEntity
	{
		public int? AttendanceDeviceId { get; set; }
		public string DeviceName { get; set; }
		public string DeviceSlNo { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }

	}
}
