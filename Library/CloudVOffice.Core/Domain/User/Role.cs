using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.User
{
    public class Role:BaseEntity
    {
        public string RoleName { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<UserRoleMapping> UserRoleMappings { get; set; }

    }
}
