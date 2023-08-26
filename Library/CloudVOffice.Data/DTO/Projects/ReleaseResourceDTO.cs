using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
	public class ReleaseResourceDTO
	{
		public int ProjectId { get; set; }
		public Int64 EmployeeId { get; set; }
		public DateTime ReleaseDate { get; set; }
	}
}
