using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Master
{
	public class Designation : IAuditEntity, ISoftDeletedEntity
	{
		public int DesignationId { get; set; }
		public string DesignationName { get; set; }
		public string Description { get; set; }	
		public int CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }
	}
}
