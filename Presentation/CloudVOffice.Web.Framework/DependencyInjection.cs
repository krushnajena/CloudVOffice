 using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Accounts;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.Customert;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Email;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Permissions;
using CloudVOffice.Services.Projects;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

			services.AddScoped<IEmailTemplateService, EmailTemplateService>();
			services.AddScoped<ICompanyDetailsService, CompanyDetailsService>();
			services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<ITokenService, TokenService>();




            services.AddScoped<ILetterHeadService, LetterHeadService>();
			
			
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
			services.AddScoped<ITimesheetActivityCategoryService, TimesheetActivityCategoryService>();
			#endregion

            #region Attendance
            services.AddScoped<IShiftTypeService, ShiftTypeService>();
            services.AddScoped<IHolidayService, HolidayService>();
            services.AddScoped<IHolidayDaysService, HolidayDaysService>();
            services.AddScoped<ILeaveTypeService, LeaveTypeService>();
			#endregion

			#region Recruitment
			services.AddScoped<IStaffingPlanService, StaffingPlanService>();
			services.AddScoped<IJobApplicationService, JobApplicationService>();
            services.AddScoped<IStaffingPlanDetailsService, StaffingPlanDetailsService>();
            services.AddScoped<IInterviewTypeService, InterviewTypeService>();
            services.AddScoped<IInterviewRoundService, InterviewRoundService>();
			services.AddScoped<IJobApplicationSourceService, JobApplicationSourceService>();
			#endregion

			#region DesktopLogin
			services.AddScoped<IDesktoploginSevice, DesktoploginSevice>();
            #endregion


			#region DesktopLogin
			services.AddScoped<IDesktoploginSevice, DesktoploginSevice>();
            services.AddScoped<IDesktopActivityLogService, DesktopActivityLogService>();
			#endregion

			#region Accounts Services
			services.AddScoped<IFinancialYearService, FinancialYearService>();
           
            services.AddScoped<IChartOfAccountsServices, ChartOfAccountsService>();

            services.AddScoped<ICustomerService, CustomerService>();
			#endregion
			
			return services;

        }
    }
}