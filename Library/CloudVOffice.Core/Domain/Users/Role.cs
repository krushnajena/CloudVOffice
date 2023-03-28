using CloudVOffice.Core.Domain.Pemission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Users
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<UserRoleMapping> UserRoleMappings { get; set; }
        public ICollection<RoleAndApplicationWisePermission> RoleAndApplicationWisePermission { get; set; }

    }
}
