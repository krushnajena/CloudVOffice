using CloudVOffice.Core.Domain.Pemission;
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

		public async Task<List<Application>> GetUserMenu(int UserId)
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
                        if (application[j].Children != null)
                        {
							if (application.Where(x => x.Children[j].ApplicationId == smenu[k].ApplicationId).ToList().Count == 0)
							{
								application[j].Children = new List<Application>();
								application[j].Children.Add(smenu[k].Application);
							}
						}
                        else
                        {
							application[j].Children = new List<Application>();
							application[j].Children.Add(smenu[k].Application);
						}
						
						var tmenu = _context.UserWiseViewMappers
							.Include(a => a.Application)
                            .Where(x => x.UserId == UserId && x.Deleted == false && x.Application.Parent == application[j].Children[k].ApplicationId).ToList();
						for (int l=0; l< tmenu.Count; l++)
                        {
                            if (application[j].Children[k] != null)
                            {
								if (application.Where(x => x.Children[j].Children[k].ApplicationId == tmenu[k].ApplicationId).ToList().Count == 0)
								{
									application[j].Children[k].Children.Add(tmenu[l].Application);
								}
							}
                            else
                            {
								application[j].Children[k].Children.Add(tmenu[l].Application);
							}
                            
                        }
					}
				}
               
			}
            return application;
            
		}
	}
}
