using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
    public  class ProjectUser : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 ProjectUserId { get; set; }
        public int ProjectId { get; set; }  
        public Int64 UserId { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }


        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }


    }
}
