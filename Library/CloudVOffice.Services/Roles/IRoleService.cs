using CloudVOffice.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Roles
{
	public interface IRoleService
	{
		public Role CreateRole(string RoleName,Int64 CreatedBy);
		public List<Role> GetAllRoles();
		public Role GetRoleById(string RoleId);
		public Role GetRoleByName(string RoleName);
		public string UpdateRole(string RoleName, int RoleId,int UpdatedBy);
		public string DeleteRole(int RoleId,int DeletedBy);
	}
}
