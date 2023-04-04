using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Permissions
{
    public interface IUserViewPermissions
    {
        public string AssignViewPermissions(Int64 UserId, int RoleId);
    }
}
