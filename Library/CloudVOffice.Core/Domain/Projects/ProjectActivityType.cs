using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class ProjectActivityType:IAuditEntity, ISoftDeletedEntity
	{
		public int ProjectActivityTypeId { get; set; }
		public string ProjectActivityName { get; set; }
		public int? ActivityCategoryId { get; set; }
		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }


    
    }
}
