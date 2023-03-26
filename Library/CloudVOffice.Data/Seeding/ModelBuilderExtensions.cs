using CloudVOffice.Core.Domain.User;
using CloudVOffice.Core.Security;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
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
                b.HasKey(e => e.Id);

                b.HasData(
                    new Role
                    {
                        Id = 1,
                        RoleName = "Administrator",

                    },

                     new Role
                     {
                         Id = 2,
                         RoleName = "DMS Manager",

                     },
                      new Role
                      {
                          Id = 3,
                          RoleName = "DMS User",

                      }

                    );
            });


            modelBuilder.Entity<User>(b =>
            {
                b.HasKey(e => e.Id);

                b.HasData(
                    new User
                    {
                        Id = 1,
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
                b.HasKey(e => e.Id);

                b.HasData(
                    new UserRoleMapping
                    {
                        Id = 1,
                        UserId = 1,
                        RoleId = 1
                    },
                    new UserRoleMapping
                    {
                        Id = 2,
                        UserId = 1,
                        RoleId = 2
                    }
                    ,
                    new UserRoleMapping
                    {
                        Id = 3,
                        UserId = 1,
                        RoleId = 3
                    }


                    );
            });
        }
    }
}
