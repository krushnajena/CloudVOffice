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

                    },

                     new Role
                     {
                         RoleId = 2,
                         RoleName = "DMS Manager",

                     },
                      new Role
                      {
                          RoleId = 3,
                          RoleName = "DMS User",

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
                    },
                    new UserRoleMapping
                    {
                        UserRoleMappingId = 2,
                        UserId = 1,
                        RoleId = 2
                    }
                    ,
                    new UserRoleMapping
                    {
                        UserRoleMappingId = 3,
                        UserId = 1,
                        RoleId = 3
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
                        Url = "/Applications/InstalledApps",
                        CreatedBy = 1,

                        CreatedDate = System.DateTime.Now,
                        Deleted = false
                    },
                      new Application
                      {
                          ApplicationId = 2,
                          ApplicationName = "Setup",
                          Parent = null,
                          IsGroup = true,
                          Url = "/Setup/Dashboard",
                          CreatedBy = 1,

                          CreatedDate = System.DateTime.Now,
                          Deleted = false


                      },
                       new Application
                       {
                           ApplicationId = 2,
                           ApplicationName = "Company",
                           Parent = 2,
                           IsGroup = false,
                           Url = "/Setup/Company",
                           CreatedBy = 1,

                           CreatedDate = System.DateTime.Now,
                           Deleted = false


                       },
                        new Application
                        {
                            ApplicationId = 2,
                            ApplicationName = "User",
                            Parent = null,
                            IsGroup = true,
                            Url = "",
                            CreatedBy = 1,

                            CreatedDate = System.DateTime.Now,
                            Deleted = false


                        },
                          new Application
                          {
                              ApplicationId = 2,
                              ApplicationName = "User List",
                              Parent = null,
                              IsGroup = true,
                              Url = "/User/UserList",
                              CreatedBy = 1,

                              CreatedDate = System.DateTime.Now,
                              Deleted = false


                          },
                          new Application
                          {
                              ApplicationId = 2,
                              ApplicationName = "Users Activity Log",
                              Parent = null,
                              IsGroup = true,
                              Url = "/User/ActivityLog",
                              CreatedBy = 1,

                              CreatedDate = System.DateTime.Now,
                              Deleted = false


                          }

                    );
            });

        }
    }
}
