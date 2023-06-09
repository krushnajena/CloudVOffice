using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.Customer;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Logging;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Core.Domain.Recruitment;
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


        #region Attendance

        public virtual DbSet<ShiftType> ShiftTypes { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }

        public virtual DbSet<HolidayDays> HolidayDays { get; set; }

        public virtual DbSet<LeaveType> LeaveTypes { get; set; }

        #endregion

        #region Recruitment
        public virtual DbSet<StaffingPlan> StaffingPlans { get; set; }
        public virtual DbSet<StaffingPlanDetails> StaffingPlanDetails { get; set; }
        public virtual DbSet<JobOpening> JobOpenings { get; set; }
        public virtual DbSet<JobApplicationSource> JobApplicationSources { get; set; }

        public virtual DbSet<JobApplication> JobApplications{ get; set; }
        public virtual DbSet<InterviewType> InterviewTypes { get; set; }
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
        public virtual DbSet<TimesheetActivityCategory> TimesheetActivityCategories { get; set; }


        #endregion



        #region Desktop Monitering

        public virtual DbSet<DesktopLogin> DesktopLogins { get; set; }


        public virtual DbSet<DesktopActivityLog> DesktopActivityLogs { get; set; }


        public virtual DbSet<DesktopKeyStroke> DesktopKeyStrokes { get; set; }
        public virtual DbSet<DesktopSnapshot> DesktopSnapshots { get; set; }
        #endregion

        #region Accounts
        public virtual DbSet<AccountType> AccountTypes{ get; set; }
        public virtual DbSet<ChartOfAccounts> ChartOfAccounts{ get; set; }

        public virtual DbSet<FinancialYear> FinancialYear { get; set; }

        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Base

            modelBuilder.Entity<Role>()
        .Property(s => s.CreatedDate)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Role>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<User>()
        .Property(s => s.CreatedDate)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<User>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<Application>()
        .Property(s => s.CreatedDate)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Application>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<RoleAndApplicationWisePermission>()
      .Property(s => s.CreatedDate)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<RoleAndApplicationWisePermission>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();




            modelBuilder.Entity<UserWiseViewMapper>()
      .Property(s => s.CreatedDate)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<UserWiseViewMapper>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<InstalledApplication>()
      .Property(s => s.CreatedDate)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<InstalledApplication>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<EmailDomain>()
      .Property(s => s.CreatedDate)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmailDomain>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<EmailAccount>()
.Property(s => s.CreatedDate)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmailAccount>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();





            modelBuilder.Entity<LetterHead>()
.Property(s => s.CreatedDate)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<LetterHead>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<CompanyDetails>()
.Property(s => s.CreatedDate)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<CompanyDetails>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<EmailTemplate>()
.Property(s => s.CreatedDate)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmailTemplate>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            #endregion


            #region HR

            modelBuilder.Entity<ShiftType>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ShiftType>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<Branch>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Branch>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Department>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Department>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<Designation>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Designation>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<EmploymentType>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmploymentType>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Employee>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Employee>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<EmployeeEducationalQualification>()
       .Property(s => s.CreatedDate)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmployeeEducationalQualification>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();





            #endregion

            #region Accounts

            modelBuilder.Entity<ChartOfAccounts>()
  .Property(s => s.CreatedDate)
  .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ChartOfAccounts>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<FinancialYear>()
  .Property(s => s.CreatedDate)
  .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<FinancialYear>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();





            modelBuilder.Entity<AccountType>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AccountType>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<CustomerGroup>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<CustomerGroup>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Customer>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Customer>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            #endregion

            #region Project
            modelBuilder.Entity<ProjectType>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProjectType>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Project>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Project>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();




            modelBuilder.Entity<ProjectEmployee>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProjectEmployee>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();





            modelBuilder.Entity<ProjectUser>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProjectUser>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();





            modelBuilder.Entity<ProjectActivityType>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProjectActivityType>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();




            modelBuilder.Entity<ProjectTask>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProjectTask>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();







            modelBuilder.Entity<Timesheet>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Timesheet>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();




            modelBuilder.Entity<TimesheetActivityCategory>()
    .Property(s => s.CreatedDate)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<TimesheetActivityCategory>()
             .Property(s => s.Deleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            #endregion

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
