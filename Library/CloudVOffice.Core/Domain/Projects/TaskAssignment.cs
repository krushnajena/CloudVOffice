using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Users;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class TaskAssignment : IAuditEntity, ISoftDeletedEntity
	{
		public Int64 TaskAssignmentId { get; set; }	
		public Int64 TaskId { get; set; }
		public Int64 EmployeeId { get; set; }
		public Int64 AssignedBy { get; set; }
		public DateTime? AssignedOn { get; set; }
		public DateTime? CompliteBy { get; set; }
		public DateTime? ActualCompliteOn { get;set; }
		public string? DelayReason { get; set; }
		public bool IsDelayApproved { get; set; }
		public Int64? DelayApprovedBy { get; set; }
		public DateTime? DelayApprovedOn { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }



        [ForeignKey("TaskId")]
        public ProjectTask ProjectTask { get; set; }


        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }



        [ForeignKey("AssignedBy")]
        public Employee EmployeeAssignedBy { get; set; }


        [ForeignKey("CompliteBy")]
        public Employee EmployeeCompliteBy { get; set; }


        [ForeignKey("DelayApprovedBy")]
        public Employee EmployeeDelayApprovedBy { get; set; }
        


    }
}

