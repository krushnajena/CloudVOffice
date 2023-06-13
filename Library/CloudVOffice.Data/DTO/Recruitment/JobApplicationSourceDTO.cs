using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class JobApplicationSourceDTO
	{
		public int? JobApplicationSourceId { get; set; }
		public string SourceName { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
