using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
	public class TimesheetActivityCategoryDTO
	{
		public int? TimesheetActivityCategoryId { get; set; }
		public string TimesheetActivityCategoryName { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
