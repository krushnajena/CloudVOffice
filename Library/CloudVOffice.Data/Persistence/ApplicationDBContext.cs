using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Logging;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.Seeding;
using Microsoft.EntityFrameworkCore;


namespace CloudVOffice.Data.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
         : base(options)
        {
        }
        public DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

        public virtual DbSet<Role> Roles  { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }


        public virtual DbSet<Application> Applications { get; set; }

        public virtual DbSet<RoleAndApplicationWisePermission> RoleAndApplicationWisePermissions { get; set; }

        public virtual DbSet<UserWiseViewMapper> UserWiseViewMappers { get; set; }

		#region HR
		    #region Master
		public virtual DbSet<Branch> Branches { get; set; }

		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Designation> Designations { get; set; }
		public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }
		#endregion
		#endregion


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();

          

          

        }






    }
}
