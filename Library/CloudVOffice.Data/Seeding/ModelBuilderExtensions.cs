using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using Microsoft.EntityFrameworkCore;

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
                b.Property(x => x.ApplicationId).ValueGeneratedOnAdd().UseIdentityColumn(10000, 1);
                b.HasData(
                    new Application
                    {
                        ApplicationId = 1,
                        ApplicationName = "Applications",
                        Parent = null,
                        IsGroup = true,
                        Url = "/Application/Applications/InstalledApps",
                        CreatedBy = 1,
                        IconImageUrl = "/appstatic/images/applications.png",
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
                b.Property(x => x.RoleAndApplicationWisePermissionId).ValueGeneratedOnAdd().UseIdentityColumn(10000, 1);
                b.HasData(
                    new RoleAndApplicationWisePermission
                    {
                        RoleAndApplicationWisePermissionId = 1,
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
                         {
                             RoleAndApplicationWisePermissionId = 5,
                             ApplicationId = 5,
                             RoleId = 1,
                             CreatedBy = 1,

                             CreatedDate = System.DateTime.Now,
                             Deleted = false
                         },
                         new RoleAndApplicationWisePermission
                         {
                             RoleAndApplicationWisePermissionId = 6,
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
                b.Property(x => x.UserWiseViewMapperId).ValueGeneratedOnAdd().UseIdentityColumn(10000, 1);
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
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"">
                                <tbody>
                                    <tr>
                                        <td align=""center"">
                                            <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"">
                                                <tbody>
                                                    <tr>
                                                        <td></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">{%welcometitle%} </h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"">
                                                            <table border=""0"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <h5 style=""font-weight:400; margin-bottom:0; font-size:16px; color:#676767""><span style=""color:rgb(22,123,158); font-size:16px; margin-right:2px; font-weight:600""></span>{%helloname%}</h5>
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">{%accountcreatetionmessage%}</p>

                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">{%loginidmessage%}</p>


                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">{%aditionalmessage%}</p>
                                                                                <div style=""margin:20px 0 0 0; text-align:center"">{%setpasswordlink%}</div>
                                                                                <br />
                                                                                {%copylinkfrommessage%}
                                                                            </div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table border=""0"" style=""width:100%"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table border=""0"" style=""width:100%"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = ""


                      },

                      new EmailTemplate
                      {
                          EmailTemplateId = 2,
                          EmailTemplateName = "ProjectAssignment",
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"" class="""">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Project Assignment Notification</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"">
                                                            <table class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td class="""" style=""vertical-align: top;"">
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <h5 style=""font-weight:400; margin-bottom:0; font-size:16px; color:#676767"">Hello {%helloname%},</h5>
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">we hope this message finds you well.we are delighted to inform you</p><p><span style=""background-color: transparent; text-align: inherit;"">that you have been assigned to a new project in our organization. This project is an essential inititative for our company's growth, and we are confident that your skills and expertise will play crucial role in its success.</span><br></p><p><span style=""background-color: transparent; text-align: inherit;""><br></span></p><p><span style=""background-color: transparent; text-align: inherit;"">Project Details:</span></p>

                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">Project Name: {%ProjectName%}</p><p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">Project Id:&nbsp;<span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">{%projectid%}</span></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Project Duration:<span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">{%startdate%} to&nbsp;<span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">{%enddate%}</span></span></span></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Project Manager:<span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">{%projectmanagername%}</span></span></span></span></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Project Description:<span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">{%projectdescription%}</span></span></span></span></span></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;""><br></span></span></span></span></span></p></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = "Project Assignment - {%ProjectName%}"
                      },
                      new EmailTemplate
                      {
                          EmailTemplateId = 3,
                          EmailTemplateName = "ProjectUn-Assignment",
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Project Un-Assignment</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"" class="""">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"" class="""">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"" class=""""><br><table class=""e-rte-table"" style=""max-width: 1356.5px;""><tbody><tr><td class=""""><div style=""margin-left:1.2rem; margin-bottom:1em""><p>Hello {%Name%}</p><p>I hope this email finds you well. We are writing to inform you about a recent change in project assignments within our organization. Regrettably, you have been un-assigned from the following project:</p>
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">Project Name: {%ProjectName%}</p>

                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">Project Id: {%ProjectId%}</p><p><br></p>


                                                                                <p>The decision to un-assign you from this project was made based on [reason for un-assignment, e.g., changes in project requirements, resource reallocation, etc.]. We understand that you may have invested time and effort into this project, and we appreciate your dedication.</p><p>Your un-assignment from this project does not reflect on your capabilities or commitment to our organization. We value your skills and contributions and look forward to involving you in future projects that align with your expertise.</p></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = "Project Un-Assignment - {%ProjectName%}"
                      },
                      new EmailTemplate
                      {
                          EmailTemplateId = 4,
                          EmailTemplateName = "TimesheetReminder",
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"" class="""">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Timesheet Updation | Reminder!</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"" class="""">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"" class="""">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"" class=""""><br><table class=""e-rte-table"" style=""max-width: 1356.5px;""><tbody><tr><td class=""""><div style=""margin-left:1.2rem; margin-bottom:1em""><p>Hello {%Name%}</p><p style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;"">This is a reminder that your timesheet updation is pending for:<span style=""background-color: transparent; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; text-align: inherit;"">&nbsp;<strong>{%Date%}</strong></span></p><p style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;"">Please log into {%appname%} to update your timesheet.</p><p style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;""><br></p><p style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;"">Failure to submit your timesheets may result in loss of Earned Leave (EL) or loss of pay.</p><p style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;"">If you have any questions regarding your Timesheet then please contact your Reporting Authority/Project Manager.</p></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = "Timesheet Updation | Reminder!"
                      },
                      new EmailTemplate
                      {
                          EmailTemplateId = 5,
                          EmailTemplateName = "TaskOverdue",
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"" class="""">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Task Overdue</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"" class="""">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"" class="""">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"" class=""""><br><table class=""e-rte-table"" style=""max-width: 1356.5px;""><tbody><tr><td class=""""><div style=""margin-left:1.2rem; margin-bottom:1em""><p>Hello {%Name%}</p><p>I hope this email finds you well. We would like to bring to your attention that there is an overdue task assigned to you with the following details:</p><p>Task Name : {%TaskName%}</p><p>Task Id : {%TaskId%}</p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Due Date : {%DueDate%}</span><br></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Project Name : {%ProjectName%}</span><br></p><p>Project Id : {%ProjectId%}</p><p>As of today, {%CurrentDate%}, the task remains incomplete and is past its due date. We understand that unforeseen circumstances may arise, leading to delays. However, it is crucial to address overdue tasks promptly to maintain project timelines and overall efficiency.</p><p><span style=""background-color: transparent; text-align: inherit;"">We kindly request you to prioritize this task and take immediate action to complete it as soon as possible. If you have encountered any obstacles or require additional resources to complete the task, please discuss with your Project Manager.</span><br></p></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = "Task Overdue"

                      },
                      new EmailTemplate
                      {
                          EmailTemplateId = 6,
                          EmailTemplateName = "TaskDueTodayReminder",
                          EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"" class="""">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Today Task Due {%TaskName%}</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"" class="""">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"" class="""">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"" class=""""><br><table class=""e-rte-table"" style=""max-width: 1356.5px;""><tbody><tr><td class=""""><div style=""margin-left:1.2rem; margin-bottom:1em""><p>Hello {%Name%}</p><p>This is a friendly reminder that the following task is due for completion today:</p><p>Task Name : {%TaskName%}</p><p>Task Id : {%TaskId%}</p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Due Date : {%DueDate%}</span><br></p><p><span style=""color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;"">Project Name : {%ProjectName%}</span><br></p><p>Project Id : {%ProjectId%}</p><p>Please ensure that you allocate sufficient time and effort to complete the task within the given deadline. Your prompt attention to this matter will help us maintain project timelines and achieve our goals efficiently.</p></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                          CreatedBy = 1,
                          CreatedDate = System.DateTime.Now,
                          Deleted = false,
                          Subject = "Reminder: Today's Task Due - {%Taskname%}"
                      },
                       new EmailTemplate
                       {

                           EmailTemplateId = 7,
                           EmailTemplateName = "PasswordReset",
                           EmailTemplateDescription = @"<div role=""document"">
    <div class=""_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark"" style=""display: none;""><br></div>  <div autoid=""_rp_w"" class=""_rp_T4"" style=""display: none;""><br></div>  <div autoid=""_rp_x"" class=""_rp_T4"" id=""Item.MessagePartBody"" style="""">
        <div class=""_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass"" id=""Item.MessageUniqueBody"" style=""font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;"">
            <div class=""rps_ad57"">
                <div>
                    <div>
                        <div style=""margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);"">
                            <table cellpadding=""0"" cellspacing=""0"" style=""padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate"" class=""e-rte-table"">
                                <tbody>
                                    <tr>
                                        <td align=""center"" class="""">
                                            <table cellpadding=""0"" cellspacing=""0"" width=""600"" style=""padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none"" class=""e-rte-table"">
                                                <tbody>
                                                    <tr>
                                                        <td><br></td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""center"" style=""min-width:590px"">
                                                            <table cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""padding:20px 0 0; border-collapse:separate"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td valign=""middle"" class="""">
                                                                            <h1 style=""color:#676767; font-weight:400; margin:0px"">Password Reset Request</h1>
                                                                        </td>
                                                                        <td valign=""middle"" align=""right"" width=""200px"">{%emailogo%}</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan=""2"" style=""text-align:center"">
                                                                            <hr width=""100%"" style=""background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px"">
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""min-width:590px"">
                                                            <table class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td class="""">
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <h5 style=""font-weight:400; margin-bottom:0; font-size:16px; color:#676767"">Hello {%helloname%}</h5><div><br></div>
                                                                                <p>We have received a request to reset your account password. To proceed with the password reset, please click on the link below:</p>
                                                                                <div style=""margin:20px 0 0 0; text-align:center"">{%setpasswordlink%}</div>
                                                                                <br>If you did not request a password reset, Please ignore this email. Your account will&nbsp;<span style=""background-color: transparent; text-align: inherit;"">remain secure, and no action is required.</span></div><div style=""margin-left:1.2rem; margin-bottom:1em""><span style=""background-color: transparent; text-align: inherit;""><p>For security reasons, this link will expire in 2 hours. If you&nbsp;<span style=""background-color: transparent; text-align: inherit;"">are unable to reset your password within this time frame,&nbsp;</span><span style=""background-color: transparent; text-align: inherit;"">please request another password reset.</span></p></span></div>
                                                                         
                                                                            <div style=""margin-left:1.2rem; margin-bottom:1em"">
                                                                                <p style=""color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px"">
                                                                                    {%emailsignature%}
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); font-size:10px"">© Copyright {%companyname%}, {%address%} </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align=""right"">
                                                                            <div style="" margin:0 20px"">{%footerletterhera%}</div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style=""width:100%"" class=""e-rte-table"">
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div style=""text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px"">
                                                                                <p style=""color:rgb(115,115,115); margin:0; font-size:10px"">
                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential
                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,
                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.
                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately
                                                                                    and permanently delete the message and any attachments. Thank you.
                                                                                </p>
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div> <div class=""_rp_c5"" style=""display: none;""><br></div>
    </div>  <span class=""PersonaPaneLauncher""><div ariatabindex=""-1"" class=""_pe_d _pe_62"" aria-expanded=""false"" tabindex=""-1"" aria-haspopup=""false"">  <div style=""display: none;""><br></div> </div></span>
</div>",
                           CreatedBy = 1,
                           CreatedDate = System.DateTime.Now,
                           Deleted = false,
                           Subject = "Password Reset Request"
                       }




                    );
            });


            #region Account Type
            modelBuilder.Entity<AccountType>(b =>
            {
                b.HasKey(e => e.AccountTypeId);

                b.HasData(
                    new AccountType
                    {
                        AccountTypeId = 1,
                        AccountTypeName = "Accumulated Depreciation",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,
                    },

                     new AccountType
                     {
                         AccountTypeId = 2,
                         AccountTypeName = "Asset Received But Not Billed",
                         CreatedBy = 1,
                         CreatedDate = DateTime.Now,
                         Deleted = false,
                     },
                       new AccountType
                       {
                           AccountTypeId = 3,
                           AccountTypeName = "Bank",
                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,
                       },

                       new AccountType
                       {
                           AccountTypeId = 4,
                           AccountTypeName = "Cash",
                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,
                       },
                         new AccountType
                         {
                             AccountTypeId = 5,
                             AccountTypeName = "Chargeable",
                             CreatedBy = 1,
                             CreatedDate = DateTime.Now,
                             Deleted = false,
                         },
                          new AccountType
                          {
                              AccountTypeId = 6,
                              AccountTypeName = "Capital Work in Progress",
                              CreatedBy = 1,
                              CreatedDate = DateTime.Now,
                              Deleted = false,
                          },

                           new AccountType
                           {
                               AccountTypeId = 7,
                               AccountTypeName = "Cost of Goods Sold",
                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,
                           },
                            new AccountType
                            {
                                AccountTypeId = 8,
                                AccountTypeName = "Depreciation",
                                CreatedBy = 1,
                                CreatedDate = DateTime.Now,
                                Deleted = false,
                            },
                            new AccountType
                            {
                                AccountTypeId = 9,
                                AccountTypeName = "Equity",
                                CreatedBy = 1,
                                CreatedDate = DateTime.Now,
                                Deleted = false,
                            },
                              new AccountType
                              {
                                  AccountTypeId = 10,
                                  AccountTypeName = "Expense Account",
                                  CreatedBy = 1,
                                  CreatedDate = DateTime.Now,
                                  Deleted = false,
                              },

                              new AccountType
                              {
                                  AccountTypeId = 11,
                                  AccountTypeName = "Expenses Included In Asset Valuation",
                                  CreatedBy = 1,
                                  CreatedDate = DateTime.Now,
                                  Deleted = false,
                              },


                              new AccountType
                              {
                                  AccountTypeId = 12,
                                  AccountTypeName = "Expenses Included In Valuation",
                                  CreatedBy = 1,
                                  CreatedDate = DateTime.Now,
                                  Deleted = false,
                              },
                              new AccountType
                              {
                                  AccountTypeId = 13,
                                  AccountTypeName = "Fixed Asset",
                                  CreatedBy = 1,
                                  CreatedDate = DateTime.Now,
                                  Deleted = false,
                              },
                                new AccountType
                                {
                                    AccountTypeId = 14,
                                    AccountTypeName = "Income Account",
                                    CreatedBy = 1,
                                    CreatedDate = DateTime.Now,
                                    Deleted = false,
                                },
                                   new AccountType
                                   {
                                       AccountTypeId = 15,
                                       AccountTypeName = "Payable",
                                       CreatedBy = 1,
                                       CreatedDate = DateTime.Now,
                                       Deleted = false,
                                   },
                                     new AccountType
                                     {
                                         AccountTypeId = 16,
                                         AccountTypeName = "Receivable",
                                         CreatedBy = 1,
                                         CreatedDate = DateTime.Now,
                                         Deleted = false,
                                     },
                                       new AccountType
                                       {
                                           AccountTypeId = 17,
                                           AccountTypeName = "Round Off",
                                           CreatedBy = 1,
                                           CreatedDate = DateTime.Now,
                                           Deleted = false,
                                       },
                                         new AccountType
                                         {
                                             AccountTypeId = 18,
                                             AccountTypeName = "Stock",
                                             CreatedBy = 1,
                                             CreatedDate = DateTime.Now,
                                             Deleted = false,
                                         },
                                           new AccountType
                                           {
                                               AccountTypeId = 19,
                                               AccountTypeName = "Stock Adjustment",
                                               CreatedBy = 1,
                                               CreatedDate = DateTime.Now,
                                               Deleted = false,
                                           },
                                            new AccountType
                                            {
                                                AccountTypeId = 20,
                                                AccountTypeName = "Stock Received But Not Billed",
                                                CreatedBy = 1,
                                                CreatedDate = DateTime.Now,
                                                Deleted = false,
                                            },
                                               new AccountType
                                               {
                                                   AccountTypeId = 21,
                                                   AccountTypeName = "Service Received But Not Billed",
                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },
                                                    new AccountType
                                                    {
                                                        AccountTypeId = 22,
                                                        AccountTypeName = "Tax",
                                                        CreatedBy = 1,
                                                        CreatedDate = DateTime.Now,
                                                        Deleted = false,
                                                    },

                                                      new AccountType
                                                      {
                                                          AccountTypeId = 23,
                                                          AccountTypeName = "Temporary",
                                                          CreatedBy = 1,
                                                          CreatedDate = DateTime.Now,
                                                          Deleted = false,
                                                      }




                    );
            });


            modelBuilder.Entity<ChartOfAccounts>(b =>
            {
                b.HasKey(e => e.ChartOfAccountsId);

                b.HasData(
                #region Asset 1
                     new ChartOfAccounts
                     {
                         ChartOfAccountsId = 1,
                         AccountName = "Application of Funds (Assets)",
                         IsGroup = true,
                         RootType = "Assets",
                         ReportType = "Balance Sheet",
                         ParentAccountGroupId = null,
                         AccountType = null,
                         AccountNumber = null,
                         TaxRate = null,
                         BalanceMustBe = null,

                         CreatedBy = 1,
                         CreatedDate = DateTime.Now,
                         Deleted = false,
                     },


                       new ChartOfAccounts
                       {
                           ChartOfAccountsId = 2,
                           AccountName = "Current Assets",
                           IsGroup = true,
                           RootType = "Assets",
                           ReportType = "Balance Sheet",
                           ParentAccountGroupId = 1,
                           AccountType = null,
                           AccountNumber = null,
                           TaxRate = null,
                           BalanceMustBe = null,

                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,
                       },

                       new ChartOfAccounts
                       {
                           ChartOfAccountsId = 3,
                           AccountName = "Accounts Receivable",
                           IsGroup = true,
                           RootType = "Assets",
                           ReportType = "Balance Sheet",
                           ParentAccountGroupId = 2,
                           AccountType = null,
                           AccountNumber = null,
                           TaxRate = null,
                           BalanceMustBe = null,

                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,
                       },
                        new ChartOfAccounts
                        {
                            ChartOfAccountsId = 4,
                            AccountName = "Debtors",
                            IsGroup = false,
                            RootType = "Assets",
                            ReportType = "Balance Sheet",
                            ParentAccountGroupId = 3,
                            AccountType = null,
                            AccountNumber = null,
                            TaxRate = null,
                            BalanceMustBe = null,

                            CreatedBy = 1,
                            CreatedDate = DateTime.Now,
                            Deleted = false,
                        },


                           new ChartOfAccounts
                           {
                               ChartOfAccountsId = 5,
                               AccountName = "Bank Accounts",
                               IsGroup = true,
                               RootType = "Assets",
                               ReportType = "Balance Sheet",
                               ParentAccountGroupId = 2,
                               AccountType = null,
                               AccountNumber = null,
                               TaxRate = null,
                               BalanceMustBe = null,

                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,
                           },



                           new ChartOfAccounts
                           {
                               ChartOfAccountsId = 6,
                               AccountName = "Cash In Hand",
                               IsGroup = true,
                               RootType = "Assets",
                               ReportType = "Balance Sheet",
                               ParentAccountGroupId = 2,
                               AccountType = null,
                               AccountNumber = null,
                               TaxRate = null,
                               BalanceMustBe = null,

                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,
                           },




                           new ChartOfAccounts
                           {
                               ChartOfAccountsId = 7,
                               AccountName = "Cash",
                               IsGroup = false,
                               RootType = "Assets",
                               ReportType = "Balance Sheet",
                               ParentAccountGroupId = 6,
                               AccountType = null,
                               AccountNumber = null,
                               TaxRate = null,
                               BalanceMustBe = null,

                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,
                           },



                           new ChartOfAccounts
                           {
                               ChartOfAccountsId = 8,
                               AccountName = "Loans and Advances (Assets)",
                               IsGroup = true,
                               RootType = "Assets",
                               ReportType = "Balance Sheet",
                               ParentAccountGroupId = 2,
                               AccountType = null,
                               AccountNumber = null,
                               TaxRate = null,
                               BalanceMustBe = null,

                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,
                           },


                             new ChartOfAccounts
                             {
                                 ChartOfAccountsId = 9,
                                 AccountName = "Securities and Deposits",
                                 IsGroup = true,
                                 RootType = "Assets",
                                 ReportType = "Balance Sheet",
                                 ParentAccountGroupId = 2,
                                 AccountType = null,
                                 AccountNumber = null,
                                 TaxRate = null,
                                 BalanceMustBe = null,

                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,
                             },


                               new ChartOfAccounts
                               {
                                   ChartOfAccountsId = 10,
                                   AccountName = "Earnest Money",
                                   IsGroup = false,
                                   RootType = "Assets",
                                   ReportType = "Balance Sheet",
                                   ParentAccountGroupId = 9,
                                   AccountType = null,
                                   AccountNumber = null,
                                   TaxRate = null,
                                   BalanceMustBe = null,

                                   CreatedBy = 1,
                                   CreatedDate = DateTime.Now,
                                   Deleted = false,
                               },


                                    new ChartOfAccounts
                                    {
                                        ChartOfAccountsId = 11,
                                        AccountName = "Stock Assets",
                                        IsGroup = true,
                                        RootType = "Assets",
                                        ReportType = "Balance Sheet",
                                        ParentAccountGroupId = 2,
                                        AccountType = null,
                                        AccountNumber = null,
                                        TaxRate = null,
                                        BalanceMustBe = null,

                                        CreatedBy = 1,
                                        CreatedDate = DateTime.Now,
                                        Deleted = false,
                                    },



                                    new ChartOfAccounts
                                    {
                                        ChartOfAccountsId = 12,
                                        AccountName = "Stock In Hand",
                                        IsGroup = false,
                                        RootType = "Assets",
                                        ReportType = "Balance Sheet",
                                        ParentAccountGroupId = 11,
                                        AccountType = null,
                                        AccountNumber = null,
                                        TaxRate = null,
                                        BalanceMustBe = null,

                                        CreatedBy = 1,
                                        CreatedDate = DateTime.Now,
                                        Deleted = false,
                                    },


                                       new ChartOfAccounts
                                       {
                                           ChartOfAccountsId = 13,
                                           AccountName = "Tax Assets",
                                           IsGroup = true,
                                           RootType = "Assets",
                                           ReportType = "Balance Sheet",
                                           ParentAccountGroupId = 2,
                                           AccountType = null,
                                           AccountNumber = null,
                                           TaxRate = null,
                                           BalanceMustBe = null,

                                           CreatedBy = 1,
                                           CreatedDate = DateTime.Now,
                                           Deleted = false,
                                       },


                                            new ChartOfAccounts
                                            {
                                                ChartOfAccountsId = 14,
                                                AccountName = "Fixed Assets",
                                                IsGroup = true,
                                                RootType = "Assets",
                                                ReportType = "Balance Sheet",
                                                ParentAccountGroupId = 1,
                                                AccountType = null,
                                                AccountNumber = null,
                                                TaxRate = null,
                                                BalanceMustBe = null,

                                                CreatedBy = 1,
                                                CreatedDate = DateTime.Now,
                                                Deleted = false,
                                            },


                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 15,
                                                   AccountName = "Accumulated Depreciations",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },






                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 16,
                                                   AccountName = "Accumulated Depreciations",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },
                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 17,
                                                   AccountName = "Buildings",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },
                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 18,
                                                   AccountName = "Capital Equipments",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },
                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 19,
                                                   AccountName = "Electronic Equipments",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },
                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 20,
                                                   AccountName = "Furnitures and Fixtures",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },


                                                   new ChartOfAccounts
                                                   {
                                                       ChartOfAccountsId = 21,
                                                       AccountName = "Office Equipments",
                                                       IsGroup = false,
                                                       RootType = "Assets",
                                                       ReportType = "Balance Sheet",
                                                       ParentAccountGroupId = 14,
                                                       AccountType = null,
                                                       AccountNumber = null,
                                                       TaxRate = null,
                                                       BalanceMustBe = null,

                                                       CreatedBy = 1,
                                                       CreatedDate = DateTime.Now,
                                                       Deleted = false,
                                                   },
                                               new ChartOfAccounts
                                               {
                                                   ChartOfAccountsId = 22,
                                                   AccountName = "Plants and Machineries",
                                                   IsGroup = false,
                                                   RootType = "Assets",
                                                   ReportType = "Balance Sheet",
                                                   ParentAccountGroupId = 14,
                                                   AccountType = null,
                                                   AccountNumber = null,
                                                   TaxRate = null,
                                                   BalanceMustBe = null,

                                                   CreatedBy = 1,
                                                   CreatedDate = DateTime.Now,
                                                   Deleted = false,
                                               },

                                                   new ChartOfAccounts
                                                   {
                                                       ChartOfAccountsId = 23,
                                                       AccountName = "Investments",
                                                       IsGroup = true,
                                                       RootType = "Assets",
                                                       ReportType = "Balance Sheet",
                                                       ParentAccountGroupId = 1,
                                                       AccountType = null,
                                                       AccountNumber = null,
                                                       TaxRate = null,
                                                       BalanceMustBe = null,

                                                       CreatedBy = 1,
                                                       CreatedDate = DateTime.Now,
                                                       Deleted = false,
                                                   },


                                                   new ChartOfAccounts
                                                   {
                                                       ChartOfAccountsId = 24,
                                                       AccountName = "Temporary Accounts",
                                                       IsGroup = true,
                                                       RootType = "Assets",
                                                       ReportType = "Balance Sheet",
                                                       ParentAccountGroupId = 1,
                                                       AccountType = null,
                                                       AccountNumber = null,
                                                       TaxRate = null,
                                                       BalanceMustBe = null,

                                                       CreatedBy = 1,
                                                       CreatedDate = DateTime.Now,
                                                       Deleted = false,
                                                   },
                                                    new ChartOfAccounts
                                                    {
                                                        ChartOfAccountsId = 25,
                                                        AccountName = "Temporary Opening",
                                                        IsGroup = false,
                                                        RootType = "Assets",
                                                        ReportType = "Balance Sheet",
                                                        ParentAccountGroupId = 24,
                                                        AccountType = null,
                                                        AccountNumber = null,
                                                        TaxRate = null,
                                                        BalanceMustBe = null,

                                                        CreatedBy = 1,
                                                        CreatedDate = DateTime.Now,
                                                        Deleted = false,
                                                    },





                #endregion Asset 1

                #region Liabilities 26

                                                      new ChartOfAccounts
                                                      {
                                                          ChartOfAccountsId = 26,
                                                          AccountName = "Source of Funds (Liabilities)",
                                                          IsGroup = true,
                                                          RootType = "Liability",
                                                          ReportType = "Balance Sheet",
                                                          ParentAccountGroupId = null,
                                                          AccountType = null,
                                                          AccountNumber = null,
                                                          TaxRate = null,
                                                          BalanceMustBe = null,

                                                          CreatedBy = 1,
                                                          CreatedDate = DateTime.Now,
                                                          Deleted = false,
                                                      },


                                                        new ChartOfAccounts
                                                        {
                                                            ChartOfAccountsId = 27,
                                                            AccountName = "Capital Account",
                                                            IsGroup = true,
                                                            RootType = "Liability",
                                                            ReportType = "Balance Sheet",
                                                            ParentAccountGroupId = 26,
                                                            AccountType = null,
                                                            AccountNumber = null,
                                                            TaxRate = null,
                                                            BalanceMustBe = null,

                                                            CreatedBy = 1,
                                                            CreatedDate = DateTime.Now,
                                                            Deleted = false,
                                                        },

                                                         new ChartOfAccounts
                                                         {
                                                             ChartOfAccountsId = 28,
                                                             AccountName = "Reserves and Surplus",
                                                             IsGroup = false,
                                                             RootType = "Liability",
                                                             ReportType = "Balance Sheet",
                                                             ParentAccountGroupId = 27,
                                                             AccountType = null,
                                                             AccountNumber = null,
                                                             TaxRate = null,
                                                             BalanceMustBe = null,

                                                             CreatedBy = 1,
                                                             CreatedDate = DateTime.Now,
                                                             Deleted = false,
                                                         },

                                                          new ChartOfAccounts
                                                          {
                                                              ChartOfAccountsId = 29,
                                                              AccountName = "Shareholders Funds",
                                                              IsGroup = false,
                                                              RootType = "Liability",
                                                              ReportType = "Balance Sheet",
                                                              ParentAccountGroupId = 27,
                                                              AccountType = null,
                                                              AccountNumber = null,
                                                              TaxRate = null,
                                                              BalanceMustBe = null,

                                                              CreatedBy = 1,
                                                              CreatedDate = DateTime.Now,
                                                              Deleted = false,
                                                          },


                                                          new ChartOfAccounts
                                                          {
                                                              ChartOfAccountsId = 30,
                                                              AccountName = "Current Liabilities",
                                                              IsGroup = true,
                                                              RootType = "Liability",
                                                              ReportType = "Balance Sheet",
                                                              ParentAccountGroupId = 26,
                                                              AccountType = null,
                                                              AccountNumber = null,
                                                              TaxRate = null,
                                                              BalanceMustBe = null,

                                                              CreatedBy = 1,
                                                              CreatedDate = DateTime.Now,
                                                              Deleted = false,
                                                          },


                                                             new ChartOfAccounts
                                                             {
                                                                 ChartOfAccountsId = 31,
                                                                 AccountName = "Accounts Payable",
                                                                 IsGroup = true,
                                                                 RootType = "Liability",
                                                                 ReportType = "Balance Sheet",
                                                                 ParentAccountGroupId = 30,
                                                                 AccountType = null,
                                                                 AccountNumber = null,
                                                                 TaxRate = null,
                                                                 BalanceMustBe = null,

                                                                 CreatedBy = 1,
                                                                 CreatedDate = DateTime.Now,
                                                                 Deleted = false,
                                                             },


                                                                   new ChartOfAccounts
                                                                   {
                                                                       ChartOfAccountsId = 32,
                                                                       AccountName = "Creditors",
                                                                       IsGroup = false,
                                                                       RootType = "Liability",
                                                                       ReportType = "Balance Sheet",
                                                                       ParentAccountGroupId = 31,
                                                                       AccountType = null,
                                                                       AccountNumber = null,
                                                                       TaxRate = null,
                                                                       BalanceMustBe = null,

                                                                       CreatedBy = 1,
                                                                       CreatedDate = DateTime.Now,
                                                                       Deleted = false,
                                                                   },

                                                                    new ChartOfAccounts
                                                                    {
                                                                        ChartOfAccountsId = 33,
                                                                        AccountName = "Payroll Payable",
                                                                        IsGroup = false,
                                                                        RootType = "Liability",
                                                                        ReportType = "Balance Sheet",
                                                                        ParentAccountGroupId = 31,
                                                                        AccountType = null,
                                                                        AccountNumber = null,
                                                                        TaxRate = null,
                                                                        BalanceMustBe = null,

                                                                        CreatedBy = 1,
                                                                        CreatedDate = DateTime.Now,
                                                                        Deleted = false,
                                                                    },



                                                                       new ChartOfAccounts
                                                                       {
                                                                           ChartOfAccountsId = 34,
                                                                           AccountName = "Duties and Taxes",
                                                                           IsGroup = true,
                                                                           RootType = "Liability",
                                                                           ReportType = "Balance Sheet",
                                                                           ParentAccountGroupId = 30,
                                                                           AccountType = null,
                                                                           AccountNumber = null,
                                                                           TaxRate = null,
                                                                           BalanceMustBe = null,

                                                                           CreatedBy = 1,
                                                                           CreatedDate = DateTime.Now,
                                                                           Deleted = false,
                                                                       },

                                                                         new ChartOfAccounts
                                                                         {
                                                                             ChartOfAccountsId = 35,
                                                                             AccountName = "TDS",
                                                                             IsGroup = false,
                                                                             RootType = "Liability",
                                                                             ReportType = "Balance Sheet",
                                                                             ParentAccountGroupId = 34,
                                                                             AccountType = null,
                                                                             AccountNumber = null,
                                                                             TaxRate = null,
                                                                             BalanceMustBe = null,

                                                                             CreatedBy = 1,
                                                                             CreatedDate = DateTime.Now,
                                                                             Deleted = false,
                                                                         },



                                                                       new ChartOfAccounts
                                                                       {
                                                                           ChartOfAccountsId = 36,
                                                                           AccountName = "Loans (Liabilities)",
                                                                           IsGroup = true,
                                                                           RootType = "Liability",
                                                                           ReportType = "Balance Sheet",
                                                                           ParentAccountGroupId = 30,
                                                                           AccountType = null,
                                                                           AccountNumber = null,
                                                                           TaxRate = null,
                                                                           BalanceMustBe = null,

                                                                           CreatedBy = 1,
                                                                           CreatedDate = DateTime.Now,
                                                                           Deleted = false,
                                                                       },



                                                                           new ChartOfAccounts
                                                                           {
                                                                               ChartOfAccountsId = 37,
                                                                               AccountName = "Bank Overdraft Account",
                                                                               IsGroup = false,
                                                                               RootType = "Liability",
                                                                               ReportType = "Balance Sheet",
                                                                               ParentAccountGroupId = 36,
                                                                               AccountType = null,
                                                                               AccountNumber = null,
                                                                               TaxRate = null,
                                                                               BalanceMustBe = null,

                                                                               CreatedBy = 1,
                                                                               CreatedDate = DateTime.Now,
                                                                               Deleted = false,
                                                                           },


                                                                               new ChartOfAccounts
                                                                               {
                                                                                   ChartOfAccountsId = 38,
                                                                                   AccountName = "Secured Loans",
                                                                                   IsGroup = false,
                                                                                   RootType = "Liability",
                                                                                   ReportType = "Balance Sheet",
                                                                                   ParentAccountGroupId = 36,
                                                                                   AccountType = null,
                                                                                   AccountNumber = null,
                                                                                   TaxRate = null,
                                                                                   BalanceMustBe = null,

                                                                                   CreatedBy = 1,
                                                                                   CreatedDate = DateTime.Now,
                                                                                   Deleted = false,
                                                                               },

                                                                                   new ChartOfAccounts
                                                                                   {
                                                                                       ChartOfAccountsId = 39,
                                                                                       AccountName = "Unsecured Loans",
                                                                                       IsGroup = false,
                                                                                       RootType = "Liability",
                                                                                       ReportType = "Balance Sheet",
                                                                                       ParentAccountGroupId = 36,
                                                                                       AccountType = null,
                                                                                       AccountNumber = null,
                                                                                       TaxRate = null,
                                                                                       BalanceMustBe = null,

                                                                                       CreatedBy = 1,
                                                                                       CreatedDate = DateTime.Now,
                                                                                       Deleted = false,
                                                                                   },


                                                                                     new ChartOfAccounts
                                                                                     {
                                                                                         ChartOfAccountsId = 40,
                                                                                         AccountName = "Stock Liabilities",
                                                                                         IsGroup = true,
                                                                                         RootType = "Liability",
                                                                                         ReportType = "Balance Sheet",
                                                                                         ParentAccountGroupId = 30,
                                                                                         AccountType = null,
                                                                                         AccountNumber = null,
                                                                                         TaxRate = null,
                                                                                         BalanceMustBe = null,

                                                                                         CreatedBy = 1,
                                                                                         CreatedDate = DateTime.Now,
                                                                                         Deleted = false,
                                                                                     },

                                                                                       new ChartOfAccounts
                                                                                       {
                                                                                           ChartOfAccountsId = 41,
                                                                                           AccountName = "Stock Received But Not Billed",
                                                                                           IsGroup = false,
                                                                                           RootType = "Liability",
                                                                                           ReportType = "Balance Sheet",
                                                                                           ParentAccountGroupId = 40,
                                                                                           AccountType = null,
                                                                                           AccountNumber = null,
                                                                                           TaxRate = null,
                                                                                           BalanceMustBe = null,

                                                                                           CreatedBy = 1,
                                                                                           CreatedDate = DateTime.Now,
                                                                                           Deleted = false,
                                                                                       },






                #endregion Liabilities 26


                #region Income 42

   new ChartOfAccounts
   {
       ChartOfAccountsId = 42,
       AccountName = "Income",
       IsGroup = true,
       RootType = "Income",
       ReportType = "Profit and Loss",
       ParentAccountGroupId = null,
       AccountType = null,
       AccountNumber = null,
       TaxRate = null,
       BalanceMustBe = null,

       CreatedBy = 1,
       CreatedDate = DateTime.Now,
       Deleted = false,
   },

     new ChartOfAccounts
     {
         ChartOfAccountsId = 43,
         AccountName = "Direct Income",
         IsGroup = true,
         RootType = "Income",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 42,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },


       new ChartOfAccounts
       {
           ChartOfAccountsId = 44,
           AccountName = "Sales",
           IsGroup = false,
           RootType = "Income",
           ReportType = "Profit and Loss",
           ParentAccountGroupId = 43,
           AccountType = null,
           AccountNumber = null,
           TaxRate = null,
           BalanceMustBe = null,

           CreatedBy = 1,
           CreatedDate = DateTime.Now,
           Deleted = false,
       },


         new ChartOfAccounts
         {
             ChartOfAccountsId = 45,
             AccountName = "Service",
             IsGroup = false,
             RootType = "Income",
             ReportType = "Profit and Loss",
             ParentAccountGroupId = 43,
             AccountType = null,
             AccountNumber = null,
             TaxRate = null,
             BalanceMustBe = null,

             CreatedBy = 1,
             CreatedDate = DateTime.Now,
             Deleted = false,
         },

          new ChartOfAccounts
          {
              ChartOfAccountsId = 46,
              AccountName = "Indirect Income",
              IsGroup = true,
              RootType = "Income",
              ReportType = "Profit and Loss",
              ParentAccountGroupId = 42,
              AccountType = null,
              AccountNumber = null,
              TaxRate = null,
              BalanceMustBe = null,

              CreatedBy = 1,
              CreatedDate = DateTime.Now,
              Deleted = false,
          },


                #endregion Income 42


                #region Expense 47
             new ChartOfAccounts
             {
                 ChartOfAccountsId = 47,
                 AccountName = "Expenses",
                 IsGroup = true,
                 RootType = "Expense",
                 ReportType = "Profit and Loss",
                 ParentAccountGroupId = null,
                 AccountType = null,
                 AccountNumber = null,
                 TaxRate = null,
                 BalanceMustBe = null,

                 CreatedBy = 1,
                 CreatedDate = DateTime.Now,
                 Deleted = false,
             },

              new ChartOfAccounts
              {
                  ChartOfAccountsId = 48,
                  AccountName = "Direct Expenses",
                  IsGroup = true,
                  RootType = "Expense",
                  ReportType = "Profit and Loss",
                  ParentAccountGroupId = 47,
                  AccountType = null,
                  AccountNumber = null,
                  TaxRate = null,
                  BalanceMustBe = null,

                  CreatedBy = 1,
                  CreatedDate = DateTime.Now,
                  Deleted = false,
              },
               new ChartOfAccounts
               {
                   ChartOfAccountsId = 49,
                   AccountName = "Stock Expenses",
                   IsGroup = true,
                   RootType = "Expense",
                   ReportType = "Profit and Loss",
                   ParentAccountGroupId = 48,
                   AccountType = null,
                   AccountNumber = null,
                   TaxRate = null,
                   BalanceMustBe = null,

                   CreatedBy = 1,
                   CreatedDate = DateTime.Now,
                   Deleted = false,
               },



                  new ChartOfAccounts
                  {
                      ChartOfAccountsId = 50,
                      AccountName = "Cost of Goods Sold",
                      IsGroup = false,
                      RootType = "Expense",
                      ReportType = "Profit and Loss",
                      ParentAccountGroupId = 49,
                      AccountType = null,
                      AccountNumber = null,
                      TaxRate = null,
                      BalanceMustBe = null,

                      CreatedBy = 1,
                      CreatedDate = DateTime.Now,
                      Deleted = false,
                  },


                  new ChartOfAccounts
                  {
                      ChartOfAccountsId = 51,
                      AccountName = "Expenses Included In Valuation",
                      IsGroup = false,
                      RootType = "Expense",
                      ReportType = "Profit and Loss",
                      ParentAccountGroupId = 49,
                      AccountType = null,
                      AccountNumber = null,
                      TaxRate = null,
                      BalanceMustBe = null,

                      CreatedBy = 1,
                      CreatedDate = DateTime.Now,
                      Deleted = false,
                  },
                  new ChartOfAccounts
                  {
                      ChartOfAccountsId = 52,
                      AccountName = "Stock Adjustment",
                      IsGroup = false,
                      RootType = "Expense",
                      ReportType = "Profit and Loss",
                      ParentAccountGroupId = 49,
                      AccountType = null,
                      AccountNumber = null,
                      TaxRate = null,
                      BalanceMustBe = null,

                      CreatedBy = 1,
                      CreatedDate = DateTime.Now,
                      Deleted = false,
                  },


                      new ChartOfAccounts
                      {
                          ChartOfAccountsId = 53,
                          AccountName = "Indirect Expenses",
                          IsGroup = true,
                          RootType = "Expense",
                          ReportType = "Profit and Loss",
                          ParentAccountGroupId = 47,
                          AccountType = null,
                          AccountNumber = null,
                          TaxRate = null,
                          BalanceMustBe = null,

                          CreatedBy = 1,
                          CreatedDate = DateTime.Now,
                          Deleted = false,
                      },








                       new ChartOfAccounts
                       {
                           ChartOfAccountsId = 54,
                           AccountName = "Administrative Expenses",
                           IsGroup = false,
                           RootType = "Expense",
                           ReportType = "Profit and Loss",
                           ParentAccountGroupId = 53,
                           AccountType = null,
                           AccountNumber = null,
                           TaxRate = null,
                           BalanceMustBe = null,

                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,
                       },

                            new ChartOfAccounts
                            {
                                ChartOfAccountsId = 55,
                                AccountName = "Commission on Sales",
                                IsGroup = false,
                                RootType = "Expense",
                                ReportType = "Profit and Loss",
                                ParentAccountGroupId = 53,
                                AccountType = null,
                                AccountNumber = null,
                                TaxRate = null,
                                BalanceMustBe = null,

                                CreatedBy = 1,
                                CreatedDate = DateTime.Now,
                                Deleted = false,
                            },

                                 new ChartOfAccounts
                                 {
                                     ChartOfAccountsId = 56,
                                     AccountName = "Depreciation",
                                     IsGroup = false,
                                     RootType = "Expense",
                                     ReportType = "Profit and Loss",
                                     ParentAccountGroupId = 53,
                                     AccountType = null,
                                     AccountNumber = null,
                                     TaxRate = null,
                                     BalanceMustBe = null,

                                     CreatedBy = 1,
                                     CreatedDate = DateTime.Now,
                                     Deleted = false,
                                 },

                                      new ChartOfAccounts
                                      {
                                          ChartOfAccountsId = 57,
                                          AccountName = "Entertainment Expenses",
                                          IsGroup = false,
                                          RootType = "Expense",
                                          ReportType = "Profit and Loss",
                                          ParentAccountGroupId = 53,
                                          AccountType = null,
                                          AccountNumber = null,
                                          TaxRate = null,
                                          BalanceMustBe = null,

                                          CreatedBy = 1,
                                          CreatedDate = DateTime.Now,
                                          Deleted = false,
                                      },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 58,
         AccountName = "Exchange Gain/Loss",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 59,
         AccountName = "Freight and Forwarding Charges",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 60,
         AccountName = "Gain/Loss on Asset Disposal",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 61,
         AccountName = "Legal Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 62,
         AccountName = "Marketing Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 63,
         AccountName = "Miscellaneous Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 64,
         AccountName = "Office Maintenance Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 65,
         AccountName = "Office Rent",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 66,
         AccountName = "Postal Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 67,
         AccountName = "Print and Stationary",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 68,
         AccountName = "Rounded Off",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 69,
         AccountName = "Salary",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 70,
         AccountName = "Sales Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 71,
         AccountName = "Telephone Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },





       new ChartOfAccounts
       {
           ChartOfAccountsId = 72,
           AccountName = "Travel Expenses",
           IsGroup = false,
           RootType = "Expense",
           ReportType = "Profit and Loss",
           ParentAccountGroupId = 53,
           AccountType = null,
           AccountNumber = null,
           TaxRate = null,
           BalanceMustBe = null,

           CreatedBy = 1,
           CreatedDate = DateTime.Now,
           Deleted = false,
       },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 73,
         AccountName = "Utility Expenses",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     },
     new ChartOfAccounts
     {
         ChartOfAccountsId = 74,
         AccountName = "Write Off",
         IsGroup = false,
         RootType = "Expense",
         ReportType = "Profit and Loss",
         ParentAccountGroupId = 53,
         AccountType = null,
         AccountNumber = null,
         TaxRate = null,
         BalanceMustBe = null,

         CreatedBy = 1,
         CreatedDate = DateTime.Now,
         Deleted = false,
     }





     #endregion Expense 47
                    );
            });





            #endregion


            #region Project Timesheet Activity Category

            modelBuilder.Entity<TimesheetActivityCategory>(b =>
            {
                b.HasKey(e => e.TimesheetActivityCategoryId);

                b.HasData(
                    new TimesheetActivityCategory
                    {
                        TimesheetActivityCategoryId = 1,
                        TimesheetActivityCategoryName = "Project Work",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,

                    },


                    new TimesheetActivityCategory
                    {
                        TimesheetActivityCategoryId = 2,
                        TimesheetActivityCategoryName = "Counselling /Discussion",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,

                    },
                    new TimesheetActivityCategory
                    {
                        TimesheetActivityCategoryId = 3,
                        TimesheetActivityCategoryName = "Documentation/Report/Policy/SOP/MIS",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,

                    },
                    new TimesheetActivityCategory
                    {
                        TimesheetActivityCategoryId = 4,
                        TimesheetActivityCategoryName = "Event Management & Participation",
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        Deleted = false,

                    },
                     new TimesheetActivityCategory
                     {
                         TimesheetActivityCategoryId = 5,
                         TimesheetActivityCategoryName = "Imaginar",
                         CreatedBy = 1,
                         CreatedDate = DateTime.Now,
                         Deleted = false,

                     },
                      new TimesheetActivityCategory
                      {
                          TimesheetActivityCategoryId = 6,
                          TimesheetActivityCategoryName = "Interviews",
                          CreatedBy = 1,
                          CreatedDate = DateTime.Now,
                          Deleted = false,

                      },
                       new TimesheetActivityCategory
                       {
                           TimesheetActivityCategoryId = 7,
                           TimesheetActivityCategoryName = "Project & Process Audit",
                           CreatedBy = 1,
                           CreatedDate = DateTime.Now,
                           Deleted = false,

                       },
                        new TimesheetActivityCategory
                        {
                            TimesheetActivityCategoryId = 8,
                            TimesheetActivityCategoryName = "Review & Monitor/Report Analysis/Meetings",
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now,
                            Deleted = false,

                        },
                         new TimesheetActivityCategory
                         {
                             TimesheetActivityCategoryId = 9,
                             TimesheetActivityCategoryName = "RFP Response",
                             CreatedBy = 1,
                             CreatedDate = DateTime.Now,
                             Deleted = false,

                         },
                          new TimesheetActivityCategory
                          {
                              TimesheetActivityCategoryId = 10,
                              TimesheetActivityCategoryName = "Project Work",
                              CreatedBy = 1,
                              CreatedDate = DateTime.Now,
                              Deleted = false,

                          },
                           new TimesheetActivityCategory
                           {
                               TimesheetActivityCategoryId = 11,
                               TimesheetActivityCategoryName = "R&D",
                               CreatedBy = 1,
                               CreatedDate = DateTime.Now,
                               Deleted = false,

                           },
                            new TimesheetActivityCategory
                            {
                                TimesheetActivityCategoryId = 12,
                                TimesheetActivityCategoryName = "Project (CSR)",
                                CreatedBy = 1,
                                CreatedDate = DateTime.Now,
                                Deleted = false,

                            },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 13,
                                 TimesheetActivityCategoryName = "Project (Product)",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 14,
                                 TimesheetActivityCategoryName = "Townhall",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 15,
                                 TimesheetActivityCategoryName = "Quality Review",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 16,
                                 TimesheetActivityCategoryName = "Performance Assessment",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 17,
                                 TimesheetActivityCategoryName = "Induction/knowledge sharing",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 18,
                                 TimesheetActivityCategoryName = "Training & Capacity Building",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 19,
                                 TimesheetActivityCategoryName = "Annual function",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             },
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 20,
                                 TimesheetActivityCategoryName = "Meetings & Reviews",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             }
                             ,
                             new TimesheetActivityCategory
                             {
                                 TimesheetActivityCategoryId = 21,
                                 TimesheetActivityCategoryName = "Travel for office Tour",
                                 CreatedBy = 1,
                                 CreatedDate = DateTime.Now,
                                 Deleted = false,

                             }


                    );
            });

            #endregion



            modelBuilder.Entity<HRSettings>(b =>
            {
                b.HasKey(e => e.HRSettingsId);

                b.HasData(
                    new HRSettings
                    {
                        HRSettingsId = 1,
                        StandardWorkingHours = 9,
                        BreakHours = 60,
                        RetirementAge = 60,

                        SendBirthdaysReminder = true,
                        SendWorkAnniversariesReminder = true,
                        SendInterviewReminder = true,
                        SendInterviewFeedbackReminder = true,
                        CreatedBy = 1
                    }


                    );

            });

        }
    }
}
