using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Accounts;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Authentication;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.Custom;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Email;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Permissions;
using CloudVOffice.Services.Projects;

using CloudVOffice.Services.Roles;
using CloudVOffice.Services.Users;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddScoped<IHRSettingsService, HRSettingsService>();
            services.AddScoped<IEmployeeGradeServices, EmployeeGradeService>();
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
            services.AddScoped<IEmployeeAttendanceService, EmployeeAttendanceService>();
            services.AddScoped<IAttendanceRequestService, AttendanceRequestService>();
            services.AddScoped<IShiftEmployeeService, ShiftEmployeeService>();

            services.AddScoped<ILeavePeriodService, LeavePeriodService>();

            services.AddScoped<IAttendanceDeviceService, AttendanceDeviceService>();
            services.AddScoped<IEmployeeBiometricDataService, EmployeeBiometricDataService>();
            services.AddScoped<IEmployeeCheckInService, EmployeeCheckInService>();
            services.AddScoped<IWorkFromHomeRequestService, WorkFromHomeRequestService>();
            #endregion





            #region DesktopLogin
            services.AddScoped<IDesktoploginSevice, DesktoploginSevice>();
            services.AddScoped<IDesktopSnapsService, DesktopSnapsService>();
            services.AddScoped<IRestrictedWebsiteService, RestrictedWebsiteService>();
            services.AddScoped<IRestrictedApplicationService, RestrictedApplicationService>();


            services.AddScoped<IDesktopActivityLogService, DesktopActivityLogService>();
            services.AddScoped<IDesktopKeystrokeService, DesktopKeystrokeService>();

            #endregion

            #region Accounts Services
            services.AddScoped<IFinancialYearService, FinancialYearService>();

            services.AddScoped<IChartOfAccountsServices, ChartOfAccountsService>();

            services.AddScoped<ICustomerService, CustomerService>();


            services.AddScoped<ICustomerGroupService, CustomerGroupService>();
            #endregion

            return services;

        }
    }
}