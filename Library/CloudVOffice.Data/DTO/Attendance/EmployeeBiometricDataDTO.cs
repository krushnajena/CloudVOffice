using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
	public class EmployeeBiometricDataDTO
	{
		public Int64? EmployeeBiometricDataId { get; set; }
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


		public IFormFile ISOImage1Up { get; set; }
		public IFormFile ISOTemplate1Up { get; set; }
		public IFormFile AnsiTemplate1Up { get; set; }
		public IFormFile RawData1Up { get; set; }
		public IFormFile WSQImage1Up { get; set; }

		public IFormFile ISOImage2Up { get; set; }
		public IFormFile ISOTemplate2Up { get; set; }
		public IFormFile AnsiTemplate2Up { get; set; }
		public IFormFile RawData2Up { get; set; }
		public IFormFile WSQImage2Up { get; set; }

		public IFormFile ISOImage3Up { get; set; }
		public IFormFile ISOTemplate3Up { get; set; }
		public IFormFile AnsiTemplate3Up { get; set; }
		public IFormFile RawData3Up { get; set; }
		public IFormFile WSQImage3Up { get; set; }
	}
}
