using Azure.Security.KeyVault.Keys;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Users
{
    public interface  IUserService
    {
		
		public Task<User> GetUserByEmailAsync(string Email);
        public User GetUserByUserId(Int64 UserId);

        public Task<UserRoleMapping> GetUserMappedRolesByUserIdAsync(int UserId);

		public List<Application> GetUserMenu(Int64 UserId);
        public Task<string> CreateUser(UserCreateDTO userCreateDTO);
        public string AssignRole(Int64 userid, int roleid);

        public string UnAssignRole(Int64 userid,int RoleId    );

        public List<User> GetAllUsers();
        public object GetUserTypes();

        public MennsageEnum DeleteUser(Int64 UserId,Int64 deletedby);

	}
}
