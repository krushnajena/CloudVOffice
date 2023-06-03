using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
    public class TimesheetActivityCategory : IAuditEntity, ISoftDeletedEntity
    {
        public int TimesheetActivityCategoryId { get; set; }
        public string TimesheetActivityCategoryName { get;set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

    }
}
