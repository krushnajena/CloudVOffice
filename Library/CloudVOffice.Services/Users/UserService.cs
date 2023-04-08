using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Permissions;
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
        private readonly ISqlRepository<UserRoleMapping> _userrolemappingRepo;
        private readonly ISqlRepository<UserWiseViewMapper> _userViewmappingRepo;
        private readonly IUserViewPermissions _userViewPermissions;
        public UserService(ApplicationDBContext context, ISqlRepository<User> userRepo, ISqlRepository<UserRoleMapping> userrolemappingRepo, IUserViewPermissions userViewPermissions)
        {
            _context = context;
            _userRepo = userRepo;
            _userrolemappingRepo = userrolemappingRepo;
            _userViewPermissions = userViewPermissions;
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

		public List<Application> GetUserMenu(Int64 UserId)
		{
			var user = _context.Users.Include(s => s.UserRoleMappings).ThenInclude(a => a.Role)

			 .Where(x => x.UserId == UserId).SingleOrDefault();
            List<Application> application = new List<Application>();
            for(int i=0;i<user.UserRoleMappings.Count;i++)
            {
                var pmenu = _context.UserWiseViewMappers
                    .Include(a=>a.Application)
                    .Where(x=>x.UserId== UserId && x.Deleted ==false && x.Application.Parent ==null).ToList();
                for(int j = 0; j < pmenu.Count; j++)
                {
                    if(application.Where(x=>x.ApplicationId == pmenu[j].ApplicationId).ToList().Count == 0)
                    {
                        pmenu[j].Application.Children = new List<Application>();

						application.Add(pmenu[j].Application);
                    }
                }
                for(int j=0;j< application.Count; j++)
                {
					var smenu = _context.UserWiseViewMappers
						.Include(a => a.Application)
                        .Where(x => x.UserId == UserId && x.Deleted == false && x.Application.Parent == application[j].ApplicationId).ToList();
					for (int k = 0; k < smenu.Count; k++)
					{
						var slist = application[j].Children;
						if (application[j].Children != null && application[j].Children.Count>0)
                        {
                            int sapplicationId = smenu[k].ApplicationId;
                          
							if (slist.Where(x => x.ApplicationId == sapplicationId).ToList().Count == 0)
							{
								smenu[k].Application.Children = new List<Application>();
								application[j].Children.Add(smenu[k].Application);
							}
						}
                        else
                        {
							smenu[k].Application.Children = new List<Application>();

							application[j].Children.Add(smenu[k].Application);
						}
						
						var tmenu = _context.UserWiseViewMappers
							.Include(a => a.Application)
                            .Where(x => x.UserId == UserId && x.Deleted == false && x.Application.Parent == application[j].Children[k].ApplicationId).ToList();
						for (int l=0; l< tmenu.Count; l++)
                        {
							var tlist = application[j].Children[k].Children;
							if (tlist != null && tlist.Count>0)
                            {
								int tapplicationId = tmenu[l].ApplicationId;

								if (tlist.Where(x => x.ApplicationId == tmenu[l].ApplicationId).ToList().Count == 0)
								{
									var napplication = tmenu[l].Application;
									application[j].Children[k].Children.Add(napplication);
								}
							}
                            else
                            {
                                var napplication = tmenu[l].Application;
								application[j].Children[k].Children.Add(napplication);
							}
                            
                        }
					}
				}
               
			}
            return application;
            
		}

        public async Task<string> CreateUser(UserCreateDTO userCreateDTO)
        {
            var objCheck = _context.Users.SingleOrDefault(opt => opt.Email == userCreateDTO.Email && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    User users = new User();
                    users.FirstName = userCreateDTO.FirstName;
                    users.MiddleName = userCreateDTO.MiddleName;
                    users.LastName = userCreateDTO.LastName;
                    users.Email = userCreateDTO.Email;
                    users.Password = Encrypt.EncryptPassword(userCreateDTO.Password, userCreateDTO.Email) ;
                    users.PhoneNo = userCreateDTO.PhoneNo;
                    users.DateOfBirth = userCreateDTO.DateOfBirth;
                    users.UserTypeId = userCreateDTO.UserTypeId;
                    users.IsActive = true;
                    users.CreatedBy = userCreateDTO.CreatedBy;
                    var obj = _userRepo.Insert(users);
                    for(int i = 0; i < userCreateDTO.roles.Count; i++)
                    {
                        if (userCreateDTO.roles[i].IsSelected == true)
                        {
                            AssignRole(obj.UserId, userCreateDTO.roles[i].RoleId);
                            _userViewPermissions.AssignViewPermissions(obj.UserId, userCreateDTO.roles[i].RoleId);
                        }
                        
                    }
                    return  "Success";

                }
                else if (objCheck != null)
                {
                     return  "Duplicate";
                }
                
                return "Unexpected";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }

        public string AssignRole(Int64 userid, int roleid)
        {
            var objCheck = _context.UserRoleMappings.SingleOrDefault(opt => opt.RoleId == roleid && opt.UserId == userid);
            try
            {
                if (objCheck == null)
                {

                    UserRoleMapping userrolemapping = new UserRoleMapping();
                    userrolemapping.RoleId = roleid;
                    userrolemapping.UserId = userid;
                    var obj = _userrolemappingRepo.Insert(userrolemapping);
                    return "Role Sucessfully Assigned";

                }
                else if (objCheck != null)
                {
                    return "Duplicate";
                }

                return "Something unexpected!";
            }
            catch (Exception ex)
            {
                return "Error!";
            }
        }

        public string UnAssignRole(Int64 userid, int roleid)
        {
            var objCheck = _context.UserRoleMappings.SingleOrDefault(opt => opt.RoleId == roleid && opt.UserId == userid);
            try
            {
                if (objCheck != null)
                {

                    _userrolemappingRepo.Delete(objCheck);
                    return "Role Sucessfully Un-Assigned";

                }
                else if (objCheck != null)
                {
                    return "Duplicate";
                }

                return "Something unexpected!";
            }
            catch (Exception ex)
            {
                return "Error!";
            }
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Where(x => x.Deleted == false).ToList();
        }

        public object GetUserTypes()
        {
			var enumData = from UserType e in Enum.GetValues(typeof(UserType))
						   select new
						   {
							   ID = (int)e,
							   Name = e.ToString()
						   };
            return enumData;
		}

	
	}
}
