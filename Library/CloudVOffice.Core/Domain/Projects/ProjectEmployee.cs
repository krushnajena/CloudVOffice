using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
    public class ProjectEmployee : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 ProjectEmployeeId { get; set; }
        public Int64 EmployeeId { get; set;}
        public int ProjectId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [JsonIgnore]
        public Project Project { get; set; }
        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
