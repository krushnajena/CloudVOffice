using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Roles
{
	public class RoleService : IRoleService
	{
		private readonly ApplicationDBContext _context;
		private readonly ISqlRepository<Role> _roleRepo;
		public RoleService(ApplicationDBContext context, ISqlRepository<Role> roleRepo) {
			_context = context; ;
			_roleRepo = roleRepo;
		}
		public string CreateRole(string RoleName, int CreatedBy)
		{
			throw new NotImplementedException();
		}

		public string DeleteRole(int RoleId, int DeletedBy)
		{
			throw new NotImplementedException();
		}

		public List<Role> GetAllRoles()
		{
			return _context.Roles.Where(x=>x.Deleted==false).ToList();
		}

		public Role GetRoleById(string RoleId)
		{
			throw new NotImplementedException();
		}

		public Role GetRoleByName(string RoleName)
		{
			throw new NotImplementedException();
		}

		public string UpdateRole(string RoleName, int RoleId, int UpdatedBy)
		{
			throw new NotImplementedException();
		}
	}
}
