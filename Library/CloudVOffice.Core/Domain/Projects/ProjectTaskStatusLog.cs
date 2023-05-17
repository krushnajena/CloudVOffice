using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class ProjectTaskStatusLog
	{
		public Int64 ProjectTaskStatusLogId { get; set; }
		public Int64 TaskId { get; set; }
		public string Status { get; set; }
		public string StatusMessage { get; set; }
		
	}
}
