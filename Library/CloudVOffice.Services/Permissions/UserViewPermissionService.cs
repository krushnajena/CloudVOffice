using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.DTO.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Permissions
{
    public class UserViewPermissionService:IUserViewPermissions
    {
        private readonly ApplicationDBContext _context;
        private readonly ISqlRepository<UserWiseViewMapper> _userWiseViewMapperRepo;
        public UserViewPermissionService(ApplicationDBContext context, ISqlRepository<UserWiseViewMapper> userWiseViewMapperRepo) {
            _context = context;
            _userWiseViewMapperRepo = userWiseViewMapperRepo;

        }

        public string AssignViewPermissions(Int64 UserId, int RoleId)
        {
            var roleWisePermissions = _context.RoleAndApplicationWisePermissions.Where(x => x.RoleId == RoleId).ToList();
            for (int j = 0; j < roleWisePermissions.Count; j++)
            {
                UserWiseViewMapper userWiseViewMapper = new UserWiseViewMapper();
                userWiseViewMapper.ApplicationId = roleWisePermissions[j].ApplicationId;
                userWiseViewMapper.UserId = UserId;
                _userWiseViewMapperRepo.Insert(userWiseViewMapper);

            }
            return "Success";
        }
    }
}
