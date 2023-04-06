using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Master
{
	public class Department : IAuditEntity, ISoftDeletedEntity
	{
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public int? Parent { get; set; }
		public bool IsGroup { get; set; }
		public int CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }
		public List<Department> Children { get; set; }
	}
}
