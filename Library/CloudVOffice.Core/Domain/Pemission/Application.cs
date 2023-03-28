using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Pemission
{
    public class Application:IAuditEntity, ISoftDeletedEntity
    {
        public int ApplicationId { get; set;  }
       
        public string ApplicationName { get; set; }

        public int? Parent { get; set; }
        public bool IsGroup { get; set; }
        public string Url { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Application> Children { get; set; }

        public ICollection<RoleAndApplicationWisePermission> RoleAndModuleWisePermission { get; set; }
        public ICollection<UserWiseViewMapper> UserWiseViewMapper { get; set; }
    }
}
