using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Roles
{
    public class UpdateRoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
