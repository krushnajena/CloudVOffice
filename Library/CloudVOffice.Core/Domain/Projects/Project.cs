    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
    public class Project : IAuditEntity, ISoftDeletedEntity
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set;}
        public string Status { get;set; }
        public int ProjectTypeId { get; set; }
        public string Priority { get; set; }
        public string CompleteMethod { get; set; }
        public int? CustomerId { get; set; }
        public Int64 ? SalesOrderId { get; set; }
        public string ProjectNotes { get; set; }
        public double? EstimatedCost { get; set; }
        public Int64? ProjectManager { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        public List<ProjectUser> ProjectUsers { get; set;}
        public List<ProjectEmployee> ProjectEmployees { get; set;}

        public virtual List<ProjectTask> ProjectTasks { get; set;}  
    }
}
