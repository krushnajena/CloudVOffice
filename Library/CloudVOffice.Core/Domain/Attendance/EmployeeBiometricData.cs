using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Attendance
{
	public class EmployeeBiometricData : IAuditEntity, ISoftDeletedEntity
	{
		public Int64 EmployeeBiometricDataId { get; set; }
		public Int64 EmployeeId { get; set; }
		public string ISOImage1 { get; set; }
		public string ISOTemplate1 { get; set; }
		public string AnsiTemplate1 { get; set; }
		public string RawData1 { get; set; }
		public string WSQImage1 { get; set; }



		public string ISOImage2 { get; set; }
		public string ISOTemplate2 { get; set; }
		public string AnsiTemplate2 { get; set; }
		public string RawData2 { get; set; }
		public string WSQImage2 { get; set; }


		public string ISOImage3 { get; set; }
		public string ISOTemplate3 { get; set; }
		public string AnsiTemplate3 { get; set; }
		public string RawData3 { get; set; }
		public string WSQImage3 { get; set; }
		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }
	}
}
