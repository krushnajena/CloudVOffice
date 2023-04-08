using CloudVOffice.Core.Domain.Pemission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Users
{
    public class Role : IAuditEntity, ISoftDeletedEntity
	{
        public int RoleId { get; set; }
        public string RoleName { get; set; }
       
		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }
		public ICollection<UserRoleMapping> UserRoleMappings { get; set; }
        public ICollection<RoleAndApplicationWisePermission> RoleAndApplicationWisePermission { get; set; }

    }
}
