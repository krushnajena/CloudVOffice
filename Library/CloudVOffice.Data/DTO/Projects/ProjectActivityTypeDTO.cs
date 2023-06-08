using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
	public class ProjectActivityTypeDTO
	{
		public int? ProjectActivityTypeId { get; set; }
		public string ProjectActivityName { get; set; }
		public int? ActivityCategory { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
