using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        }
    }
}
