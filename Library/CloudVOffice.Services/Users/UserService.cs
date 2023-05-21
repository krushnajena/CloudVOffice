using Azure.Security.KeyVault.Keys;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Permissions;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
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
		private readonly IEmailTemplateService _emailTemplateService;
	
		public UserService(ApplicationDBContext context,
            ISqlRepository<User> userRepo,
            ISqlRepository<UserRoleMapping> userrolemappingRepo,
            IUserViewPermissions userViewPermissions,
			 IEmailTemplateService emailTemplateService)
        {
            _context = context;
            _userRepo = userRepo;
            _userrolemappingRepo = userrolemappingRepo;
            _userViewPermissions = userViewPermissions;
			_emailTemplateService = emailTemplateService;
		}


        public async Task<User> GetUserByEmailAsync(string Email)
        {
            var user = _context.Users.Include(s=>s.UserRoleMappings).ThenInclude(a=>a.Role)
                
                .Where(x => x.Email == Email).SingleOrDefault();

            return user;
        }

        public User GetUserByUserId(Int64 UserId)
        {
            return _context.Users
                  .Include(x => x.UserRoleMappings)
                .Where(x => x.Deleted == false && x.UserId == UserId).SingleOrDefault();
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

        public async Task<MennsageEnum> CreateUser(UserCreateDTO userCreateDTO)
        {
            var objCheck = _context.Users
               
                .SingleOrDefault(opt => opt.Email == userCreateDTO.Email && opt.Deleted == false);
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
                    SendWelcomeMessage(obj.UserId);

					return MennsageEnum.Success;

                }
                else if (objCheck != null)
                {
                     return MennsageEnum.Duplicate;
                }
                
                return MennsageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public async Task<MennsageEnum> UpdateUser(UserCreateDTO userCreateDTO)
        {
            var user = _context.Users
                .Include(x => x.UserRoleMappings)
                .Include(x => x.UserWiseViewMapper)
                .SingleOrDefault(opt => opt.UserId == userCreateDTO.UserId && opt.Deleted == false);
            if (user != null)
            {
                user.FirstName = userCreateDTO.FirstName;
                user.MiddleName = userCreateDTO.MiddleName;
                user.LastName = userCreateDTO.LastName;

                user.DateOfBirth = userCreateDTO.DateOfBirth;
                user.PhoneNo= userCreateDTO.PhoneNo;
                user.UserTypeId = userCreateDTO.UserTypeId;
                user.UpdatedBy = userCreateDTO.CreatedBy;
                user.UpdatedDate = DateTime.Now;
                _context.SaveChanges();
                var userAssignedRoles = user.UserRoleMappings.ToList();
                var userRoles = userCreateDTO.roles.Where(x=>x.IsSelected==true).ToList();
                var UnAsignedRoles = userAssignedRoles.Where(x=> !userRoles.Any(a=>a.RoleId==x.RoleId)).ToList();
                for(int i=0; i<UnAsignedRoles.Count;i++)
                {
                    UnAssignRole(user.UserId, UnAsignedRoles[i].RoleId);
                    _userViewPermissions.UnAssignViewPermissions(user.UserId, userCreateDTO.roles[i].RoleId);

                }
                for (int i = 0; i < userCreateDTO.roles.Count; i++)
                {
                    if (userCreateDTO.roles[i].IsSelected == true)
                    {
                        AssignRole(user.UserId, userCreateDTO.roles[i].RoleId);
                        _userViewPermissions.AssignViewPermissions(user.UserId, userCreateDTO.roles[i].RoleId);
                    }

                }
                return MennsageEnum.Success;
            }
            else
                return MennsageEnum.Invalid;
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

                    _userrolemappingRepo.Delete(objCheck.UserRoleMappingId);
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

		public MennsageEnum DeleteUser(Int64 UserId ,Int64 deletedby)
		{
            try
            {
                var a = _context.Users.Where(x => x.UserId == UserId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = deletedby;
                    a.UpdatedDate = DateTime.Now;
                    _context.SaveChanges();
                    return MennsageEnum.Deleted;
                }
                else
                    return MennsageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public List<User> GetUsersByUserType(UserType userType)
        {
            return _context.Users.Where(x=>x.UserType == userType && x.Deleted == false).ToList();
        }

		public async void SendWelcomeMessage(long UserId)
		{
            try
            {
               

		
			}
            catch
            {
                throw;
            }
		}
	}
}
