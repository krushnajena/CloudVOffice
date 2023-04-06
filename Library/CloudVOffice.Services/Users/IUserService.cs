using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Users;
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
        public Task<User> GetUserByUserIdAsync(int UserId);

        public Task<UserRoleMapping> GetUserMappedRolesByUserIdAsync(int UserId);

		public List<Application> GetUserMenu(Int64 UserId);
        public Task<string> CreateUser(UserCreateDTO userCreateDTO);
        public string AssignRole(Int64 userid, int roleid);

        public string UnAssignRole(Int64 userid,int RoleId    );

        public List<User> GetAllUsers();
    }
}
