using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.Seeding
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(b =>
            {
                b.HasKey(e => e.RoleId);

                b.HasData(
                    new Role
                    {
                        RoleId = 1,
                        RoleName = "Administrator",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,

                    }

                    );
            });


            modelBuilder.Entity<User>(b =>
            {
                b.HasKey(e => e.UserId);

                b.HasData(
                    new User
                    {
                        UserId = 1,
                        FirstName = "Administrator",
                        LastName = "",
                        Email = "admin@appman.in",
                        Password = Encrypt.EncryptPassword("Appman@2019", "admin@appman.in"),
                        PhoneNo = "9583000000",
                        UserTypeId = 1,
                        CreatedBy = 1,
                        CreatedDate = System.DateTime.Now,
                        Deleted = false,
                        IsActive = true

                    }

                    );
            });

            modelBuilder.Entity<UserRoleMapping>(b =>
            {
                b.HasKey(e => e.UserRoleMappingId);

                b.HasData(
                    new UserRoleMapping
                    {
                        UserRoleMappingId = 1,
                        UserId = 1,
                        RoleId = 1
                    }


                    );
            });

            modelBuilder.Entity<Application>(b =>
            {
                b.HasKey(e => e.ApplicationId);

                b.HasData(
                    new Application
                    {
                        ApplicationId = 1,
                        ApplicationName = "Applications",
                        Parent = null,
                        IsGroup = true,
                        Url = "/Application/Applications/InstalledApps",
                        CreatedBy = 1,
                        IconImageUrl="/appstatic/images/applications.png",
                        CreatedDate = System.DateTime.Now,
                        AreaName = "Application",

						Deleted = false
                    },
                      new Application
                      {
                          ApplicationId = 2,
                          ApplicationName = "Setup",
                          Parent = null,
                          IsGroup = true,
                          Url = "/Setup/Setup/Dashboard",
                          CreatedBy = 1,
                          IconImageUrl = "/appstatic/images/setup.png",
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
						  AreaName = "Setup"


					  },
                       new Application
                       {
                           ApplicationId = 3,
                           ApplicationName = "Company",
                           Parent = 2,
                           IsGroup = false,
                           Url = "/Setup/Company/Company",
                           CreatedBy = 1,

                           CreatedDate = System.DateTime.Now,
                           Deleted = false,

						   AreaName = "Setup"

					   },
                        new Application
                        {
                            ApplicationId = 4,
                            ApplicationName = "User",
                            Parent = 2,
                            IsGroup = true,
                            Url = "",
                            CreatedBy = 1,

                            CreatedDate = System.DateTime.Now,
                            Deleted = false,

							AreaName = "Setup"

						},
                          new Application
                          {
                              ApplicationId = 5,
                              ApplicationName = "User List",
                              Parent = 4,
                              IsGroup = false,
                              Url = "/Setup/User/UserList",
                              CreatedBy = 1,

                              CreatedDate = System.DateTime.Now,
                              Deleted = false,
							  AreaName = "Setup"


						  },
                          new Application
                          {
                              ApplicationId = 6,
                              ApplicationName = "Users Activity Log",
                              Parent = 2,
                              IsGroup = false,
                              Url = "/Setup/User/ActivityLog",
                              CreatedBy = 1,

                              CreatedDate = System.DateTime.Now,
                              Deleted = false,
							  AreaName = "Setup"


						  }

                    );

            });


            modelBuilder.Entity<RoleAndApplicationWisePermission>(b =>
            {
                b.HasKey(e => e.RoleAndApplicationWisePermissionId);

                b.HasData(
                    new RoleAndApplicationWisePermission
                    {RoleAndApplicationWisePermissionId=1,
                        ApplicationId = 1,
                        RoleId = 1,
                        CreatedBy = 1,
                        
                        CreatedDate = System.DateTime.Now,
                        Deleted = false
                    },
                      new RoleAndApplicationWisePermission
                      {
                          RoleAndApplicationWisePermissionId = 2,
                          ApplicationId = 2,
                          RoleId = 1,
                          CreatedBy = 1,

                          CreatedDate = System.DateTime.Now,
                          Deleted = false
                      },
                       new RoleAndApplicationWisePermission
                       {
                           RoleAndApplicationWisePermissionId = 3,
                           ApplicationId = 3,
                           RoleId = 1,
                           CreatedBy = 1,

                           CreatedDate = System.DateTime.Now,
                           Deleted = false
                       },
                         new RoleAndApplicationWisePermission
                         {
                             RoleAndApplicationWisePermissionId = 4,
                             ApplicationId = 4,
                             RoleId = 1,
                             CreatedBy = 1,

                             CreatedDate = System.DateTime.Now,
                             Deleted = false
                         },
                         new RoleAndApplicationWisePermission
                         {RoleAndApplicationWisePermissionId = 5,
                             ApplicationId = 5,
                             RoleId = 1,
                             CreatedBy = 1,

                             CreatedDate = System.DateTime.Now,
                             Deleted = false
                         },
                         new RoleAndApplicationWisePermission
                         {RoleAndApplicationWisePermissionId = 6,
                             ApplicationId = 6,
                             RoleId = 1,
                             CreatedBy = 1,

                             CreatedDate = System.DateTime.Now,
                             Deleted = false
                         }




                    );

            });


            modelBuilder.Entity<UserWiseViewMapper>(b =>
            {
                b.HasKey(e => e.UserWiseViewMapperId);

                b.HasData(
                    new UserWiseViewMapper
                    {
                        UserWiseViewMapperId = 1,
                        ApplicationId = 1,
                        UserId = 1,
                        CreatedBy = 1,

                        CreatedDate = System.DateTime.Now,
                        Deleted = false
                    },
                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 2,
                         ApplicationId = 2,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },
                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 3,
                         ApplicationId = 3,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },
                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 4,
                         ApplicationId = 4,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },
                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 5,
                         ApplicationId = 5,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },
                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 6,
                         ApplicationId = 6,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     }




                    );

            });


        }
    }
}
