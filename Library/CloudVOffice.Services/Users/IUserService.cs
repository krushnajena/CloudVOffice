using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
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

		public Task<List<Application>> GetUserMenu(int UserId);
    }
}
