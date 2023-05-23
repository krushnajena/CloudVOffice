using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Logging;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace CloudVOffice.Data.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
         : base(options)
        {

        }
		#region
		public DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

        public virtual DbSet<Role> Roles  { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }


        public virtual DbSet<Application> Applications { get; set; }

        public virtual DbSet<RoleAndApplicationWisePermission> RoleAndApplicationWisePermissions { get; set; }

        public virtual DbSet<UserWiseViewMapper> UserWiseViewMappers { get; set; }


        public virtual DbSet<InstalledApplication> InstalledApplications{ get; set; }


        public virtual DbSet<EmailDomain> EmailDomains { get; set; }


        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<LetterHead> LetterHeads { get; set; }

        public virtual DbSet<CompanyDetails> CompanyDetails { get; set; }   
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }    
		#endregion

		#region HR
		#region Master
		public virtual DbSet<Branch> Branches { get; set; }

		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Designation> Designations { get; set; }
		public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }
		#endregion
		

		#region Employee
		public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeEducationalQualification> EmployeeEducationalQualifications { get; set; }
        #endregion
        #endregion

        #region Project
        public virtual DbSet<ProjectType> ProjectTypes { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
		public virtual DbSet<ProjectActivityType> ProjectActivityTypes { get; set; }
		public virtual DbSet<ProjectTask> ProjectTasks { get; set; }

     


        public virtual DbSet<Timesheet> Timesheets { get; set; }


        #endregion

        #region Desktop Monitering

        public virtual DbSet<DesktopLogin> DesktopLogins { get; set; }


        public virtual DbSet<DesktopActivityLog> DesktopActivityLogs { get; set; }


        public virtual DbSet<DesktopKeyStroke> DesktopKeyStrokes { get; set; }
        public virtual DbSet<DesktopSnapshot> DesktopSnapshots { get; set; }
        #endregion

        #region Accounts
        public virtual DbSet<ChartOfAccounts> ChartOfAccounts{ get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProjectTask>()
    .HasOne(r => r.Employee)
    .WithMany()
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectTask>()
    .HasOne(r => r.AssignedTo)
    .WithMany()
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Seed();







        }






    }
}
