using CloudVOffice.Core.Domain.EmailTemplates;
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
                           ApplicationName = "Company Settings",
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
                            ApplicationId = 4,
                            ApplicationName = "Company",
                            Parent = 3,
                            IsGroup = false,
                            Url = "/Setup/CompanyDetails/CompanyDetailsView",
                            CreatedBy = 1,

                            CreatedDate = System.DateTime.Now,
                            Deleted = false,

                            AreaName = "Setup"

                        },
                        new Application
                        {
                            ApplicationId = 5,
                            ApplicationName = "Letter Head",
                            Parent = 3,
                            IsGroup = false,
                            Url = "/Setup/LetterHead/LetterHeadView",
                            CreatedBy = 1,

                            CreatedDate = System.DateTime.Now,
                            Deleted = false,

                            AreaName = "Setup"

                        },
                        new Application
                        {
                            ApplicationId = 6,
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
                              ApplicationId = 7,
                              ApplicationName = "User List",
                              Parent = 6,
                              IsGroup = false,
                              Url = "/Setup/User/UserList",
                              CreatedBy = 1,

                              CreatedDate = System.DateTime.Now,
                              Deleted = false,
							  AreaName = "Setup"


						  },
                         

                            new Application
                            {
                                ApplicationId = 8,
                                ApplicationName = "Email Setup",
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
                                ApplicationId = 9,
                                ApplicationName = "Domain",
                                Parent = 8,
                                IsGroup = true,
                                Url = "/Setup/EmailDomain/EmailDomainView",
                                CreatedBy = 1,

                                CreatedDate = System.DateTime.Now,
                                Deleted = false,
                                AreaName = "Setup"


                            },
                              new Application
                              {
                                  ApplicationId = 10,
                                  ApplicationName = "Email Account",
                                  Parent = 8,
                                  IsGroup = true,
                                  Url = "/Setup/EmailAccount/EmailAccountView",
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
                         },
                             new RoleAndApplicationWisePermission
                             {
                                 RoleAndApplicationWisePermissionId = 7,
                                 ApplicationId = 7,
                                 RoleId = 1,
                                 CreatedBy = 1,

                                 CreatedDate = System.DateTime.Now,
                                 Deleted = false
                             },

                             new RoleAndApplicationWisePermission
                             {
                                 RoleAndApplicationWisePermissionId = 8,
                                 ApplicationId = 8,
                                 RoleId = 1,
                                 CreatedBy = 1,

                                 CreatedDate = System.DateTime.Now,
                                 Deleted = false
                             },


                             new RoleAndApplicationWisePermission
                             {
                                 RoleAndApplicationWisePermissionId = 9,
                                 ApplicationId = 9,
                                 RoleId = 1,
                                 CreatedBy = 1,

                                 CreatedDate = System.DateTime.Now,
                                 Deleted = false
                             },


                             new RoleAndApplicationWisePermission
                             {
                                 RoleAndApplicationWisePermissionId = 10,
                                 ApplicationId = 10,
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
                     },

                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 7,
                         ApplicationId = 7,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },

                     new UserWiseViewMapper
                     {
                         UserWiseViewMapperId = 8,
                         ApplicationId = 8,
                         UserId = 1,
                         CreatedBy = 1,

                         CreatedDate = System.DateTime.Now,
                         Deleted = false
                     },
                      new UserWiseViewMapper
                      {
                          UserWiseViewMapperId = 9,
                          ApplicationId = 9,
                          UserId = 1,
                          CreatedBy = 1,

                          CreatedDate = System.DateTime.Now,
                          Deleted = false
                      },

                       new UserWiseViewMapper
                       {
                           UserWiseViewMapperId = 10,
                           ApplicationId = 10,
                           UserId = 1,
                           CreatedBy = 1,

                           CreatedDate = System.DateTime.Now,
                           Deleted = false
                       }





                    );

            });

            modelBuilder.Entity<EmailTemplate>(x =>
            {
                x.HasKey(e => e.EmailTemplateId);
                x.HasData(
                    new EmailTemplate
                    {
                        EmailTemplateId = 1,
                        EmailTemplateName = "WelcomeEmail",
                        EmailTemplateDescription = @"<div class=""""> <div class=""aHl""><br></div> <div id="":1pw"" tabindex=""-1""><br></div> <div id="":1q7"" class=""ii gt"" > <div id="":1q8"" class=""a3s aiL msg-3184750674626119538""> <u>​</u> <div style=""color:#1f272e;line-height:1.5""> <table class=""m_-3184750674626119538body-table m_-3184750674626119538with-container e-rte-table"" cellpadding=""0"" cellspacing=""0"" style=""border-collapse:collapse;border-spacing:0;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;font-size:14px;font-weight:400;line-height:1.4;margin:0 auto;table-layout:fixed;background-color:#f4f5f6;color:#1f272e;height:100%!important;width:100%!important"" bgcolor=""#f4f5f6"" height=""100% !important"" width=""100% !important""> <tbody> <tr> <td class=""m_-3184750674626119538body-content"" align=""center"" valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif;padding:60px 40px""> <table class=""m_-3184750674626119538email-container e-rte-table"" border=""0"" cellpadding=""0"" cellspacing=""0"" width="" 600 "" style=""background-color:#fff;border-radius:8px;border-spacing:0;max-width:600px;overflow:hidden;padding:30px"" bgcolor=""#ffffff""> <tbody> <tr> <td width=""40"" align=""left"" valign=""middle"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif"" class=""""> {%emailogo%} </td> </tr> <tr> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif""> <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100% !important"" style=""min-width:100%!important;width:100%!important"" class=""e-rte-table""> <tbody> <tr> <td style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif"" class=""""> <h1 style=""font-size:20px;font-weight:600;margin-top:20px!important""> <span>​</span> <span><span class=""il""> {%welcometitle%} </span></span> </h1> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif""> <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100% !important"" style=""color:#1f272e;font-size:14px;border-radius:0 0 4px 4px;border-top:none;min-width:100%!important;width:100%!important"" class=""e-rte-table""> <tbody> <tr style=""border-bottom:none;border-collapse:collapse""> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif""> <p style=""margin:5px 0!important""><br></p> <p style=""margin:5px 0!important""> {%helloname%} </p> <p style=""margin:5px 0!important""> {%accountcreatetionmessage%} </p> <p style=""margin:5px 0!important""> {%loginidmessage%} </p> <p style=""margin:5px 0!important""> {%aditionalmessage%} </p> <p style=""margin:15px 0""> {%setpasswordlink%} </p> <br> <p style=""margin:5px 0!important;margin-top:15px""> {%emailsignature%} </p> <br> <p style=""margin:5px 0!important""> {%copylinkfrommessage%} </p> </td> </tr> </tbody> </table> </td> </tr> <tr> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif""> <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100% !important"" style=""font-size:12px;line-height:20px;border-top:none;min-width:100%!important;width:100%!important"" class=""e-rte-table""> <tbody> <tr> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif"" class=""""> <div style=""margin-top:40px;color:#687178!important""> <div> <div style=""white-space:normal""> <p style=""margin:0!important""><br></p> </div> </div> <div> <div>------------------------------<wbr>------------------------------<wbr>------</div> <div></div> <div>This is a system generated mail. Please do not reply to this email.</div> <div></div> <div>© Copyright {%companyname%}, {%address%}</div> <div></div> <div> {%footerletterhera%} </div> <div></div> <div>The information contained in this e-mail message and/or attachments to it may contain confidential <br>or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,<br> printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited. <br>If you have received this communication in error, please notify us by reply e-mail or telephone and immediately <br>and permanently delete the message and any attachments. Thank you.</div> </div> <div> </div> </div> </td> </tr> <tr> <td valign=""top"" style=""font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,Oxygen,Ubuntu,Cantarell,Fira Sans,Droid Sans,Helvetica Neue,sans-serif""> <div><br></div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> <div class=""yj6qo""><br></div> <div class=""adL""></div> </div> <div class=""adL""> </div> </div> </div> <div id="":1ps"" class=""ii gt"" style=""display:none""> <div id="":1pr"" class=""a3s aiL ""><br></div> </div> <div class=""hi""><br></div> </div>",
                        CreatedBy = 1,
                        CreatedDate = System.DateTime.Now,
                        Deleted = false,
                        Subject = ""


                    }
                    ) ;
            });


        }
    }
}
