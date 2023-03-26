using CloudVOffice.Core.Domain.Logging;
using CloudVOffice.Core.Domain.User;
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
        public DbSet<Log> Logs { get; set; }

        public DbSet<Role> Roles  { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();

        }






    }
}
