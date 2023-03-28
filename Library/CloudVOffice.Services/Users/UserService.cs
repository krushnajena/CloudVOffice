using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Users
{
    public class UserService:IUserService
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<User> _userRepo;
        public UserService(ApplicationDBContext context, ISqlRepository<User> userRepo)
        {
            _context = context;
            _userRepo = userRepo;

        }

        public async Task<User> GetUserByEmailAsync(string Email)
        {
            var user = _context.Users.Include(s=>s.UserRoleMappings).ThenInclude(a=>a.Role)
                
                .Where(x => x.Email == Email).SingleOrDefault();

            return user;
        }

        public Task<User> GetUserByUserIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserRoleMapping> GetUserMappedRolesByUserIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
