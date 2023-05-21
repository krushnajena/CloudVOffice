 using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Permissions;
using CloudVOffice.Services.Projects;
using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Web.Framework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));
            services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserViewPermissions, UserViewPermissionService>();
            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<IApplicationInstallationService, ApplicationInstallationService>();
			services.AddScoped<IHttpWebClients, HttpWebClients>();
			services.AddScoped<IEmailAccountService, EmailAccountService>();
			services.AddScoped<IEmailDomainService, EmailDomainService>();
			#region HR Services
			#region Masters
			services.AddScoped<IDepartmentService, DepartmentService>();
			
			#region HR Services
			#region Masters
			services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDesignationService, DesignationService>();
            services.AddScoped<IEmploymentTypeService, EmploymentTypeService>();
            services.AddScoped<IBranchService, BranchService>();
            #endregion

            services.AddScoped<IEmployeeService, EmployeeService>();
            #endregion

            #region Project Services
            services.AddScoped<IProjectTypeService, ProjectTypeService>();
			services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectActivityTypeService, ProjectActivityTypeService>();
			services.AddScoped<IProjectTaskService, ProjectTaskService>();
			services.AddScoped<IProjectUserService, ProjectUserService>();
			services.AddScoped<IProjectEmployeeService, ProjectEmployeeService>();
			services.AddScoped<ITimesheetService, TimesheetService>();
			#endregion

			#region DesktopLogin
			services.AddScoped<IDesktoploginSevice, DesktoploginSevice>();
            services.AddScoped<IDesktopActivityLogService, DesktopActivityLogService>();
            #endregion
            return services;
        }
    }
}
