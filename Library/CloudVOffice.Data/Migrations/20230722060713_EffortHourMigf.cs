using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class EffortHourMigf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityLogTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLogTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IconImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Applications_ApplicationId1",
                        column: x => x.ApplicationId1,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccounts",
                columns: table => new
                {
                    ChartOfAccountsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    RootType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccountGroupId = table.Column<int>(type: "int", nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: true),
                    TaxRate = table.Column<double>(type: "float", nullable: true),
                    BalanceMustBe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ChartOfAccountsId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccounts", x => x.ChartOfAccountsId);
                    table.ForeignKey(
                        name: "FK_ChartOfAccounts_ChartOfAccounts_ChartOfAccountsId1",
                        column: x => x.ChartOfAccountsId1,
                        principalTable: "ChartOfAccounts",
                        principalColumn: "ChartOfAccountsId");
                });

            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    CompanyDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ABBR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfEstablishment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfIncorporation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.CompanyDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerGroups",
                columns: table => new
                {
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerGroups", x => x.CustomerGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DepartmentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Departments_DepartmentId1",
                        column: x => x.DepartmentId1,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "EmailDomains",
                columns: table => new
                {
                    EmailDomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomingServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomingPort = table.Column<int>(type: "int", nullable: false),
                    IncomingIsIMAP = table.Column<bool>(type: "bit", nullable: false),
                    IncomingIsSsl = table.Column<bool>(type: "bit", nullable: false),
                    IncomingIsStartTLs = table.Column<bool>(type: "bit", nullable: false),
                    OutingServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutgoingPort = table.Column<int>(type: "int", nullable: false),
                    OutgoingIsTLs = table.Column<bool>(type: "bit", nullable: false),
                    OutgoingIsSsl = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailDomains", x => x.EmailDomainId);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    EmailTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultSendingAccount = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.EmailTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    EmploymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.EmploymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYear",
                columns: table => new
                {
                    FinancialYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinancialYearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYear", x => x.FinancialYearId);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    HolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.HolidayId);
                });

            migrationBuilder.CreateTable(
                name: "HRSettings",
                columns: table => new
                {
                    HRSettingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardWorkingHours = table.Column<double>(type: "float", nullable: true),
                    BreakHours = table.Column<double>(type: "float", nullable: true),
                    RetirementAge = table.Column<int>(type: "int", nullable: true),
                    SendBirthdaysReminder = table.Column<bool>(type: "bit", nullable: false),
                    SendWorkAnniversariesReminder = table.Column<bool>(type: "bit", nullable: false),
                    SendInterviewReminder = table.Column<bool>(type: "bit", nullable: false),
                    SendInterviewFeedbackReminder = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRSettings", x => x.HRSettingsId);
                });

            migrationBuilder.CreateTable(
                name: "InstalledApplications",
                columns: table => new
                {
                    InstalledApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstalledApplications", x => x.InstalledApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "InterviewTypes",
                columns: table => new
                {
                    InterviewTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewTypes", x => x.InterviewTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationSources",
                columns: table => new
                {
                    JobApplicationSourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationSources", x => x.JobApplicationSourceId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumLeaveAllocationAllowed = table.Column<int>(type: "int", nullable: true),
                    ApplicableAfterWorkingDays = table.Column<int>(type: "int", nullable: true),
                    MaximumConsecutiveLeavesAllowed = table.Column<int>(type: "int", nullable: true),
                    IsCarryForward = table.Column<bool>(type: "bit", nullable: false),
                    MaximumCarryForwardedLeaves = table.Column<int>(type: "int", nullable: true),
                    ExpireCarryForwardedLeaves = table.Column<int>(type: "int", nullable: true),
                    IsLeaveWithoutPay = table.Column<bool>(type: "bit", nullable: false),
                    IsPartiallyPaidLeave = table.Column<bool>(type: "bit", nullable: false),
                    IsOptionalLeave = table.Column<bool>(type: "bit", nullable: false),
                    AllowNegativeBalance = table.Column<bool>(type: "bit", nullable: false),
                    AllowOverAllocation = table.Column<bool>(type: "bit", nullable: false),
                    IsCompensatory = table.Column<bool>(type: "bit", nullable: false),
                    AllowEncashment = table.Column<bool>(type: "bit", nullable: false),
                    EncashmentThresholdDays = table.Column<int>(type: "int", nullable: true),
                    EarningSalaryComponentId = table.Column<int>(type: "int", nullable: true),
                    IsEarnedLeave = table.Column<bool>(type: "bit", nullable: false),
                    EarnedLeaveFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasedOnDateOfJoining = table.Column<bool>(type: "bit", nullable: false),
                    Rounding = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.LeaveTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LetterHeads",
                columns: table => new
                {
                    LetterHeadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LetterHeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadImageHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadImageWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadAlign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadFooterImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadImageFooterHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadImageFooterWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterHeadFooterAlign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LetterHeads", x => x.LetterHeadId);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogLevelId = table.Column<int>(type: "int", nullable: false),
                    ShortMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    PageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferrerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectActivityTypes",
                columns: table => new
                {
                    ProjectActivityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectActivityTypes", x => x.ProjectActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.ProjectTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Refresh_Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ShiftTypes",
                columns: table => new
                {
                    ShiftTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    LateEntryGracePeriodInMinutes = table.Column<int>(type: "int", nullable: true),
                    EarlyExitGracePeriodInMinutes = table.Column<int>(type: "int", nullable: true),
                    ThresholdforHalfDayInHours = table.Column<double>(type: "float", nullable: true),
                    ThresholdforAbsentInHours = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTypes", x => x.ShiftTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetActivityCategories",
                columns: table => new
                {
                    TimesheetActivityCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimesheetActivityCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetActivityCategories", x => x.TimesheetActivityCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: true),
                    LastIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ResetPasswordToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPasswordTokenExpirey = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "RestrictedApplications",
                columns: table => new
                {
                    RestrictedApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestrictedApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictedApplications", x => x.RestrictedApplicationId);
                    table.ForeignKey(
                        name: "FK_RestrictedApplications_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "RestrictedWebsites",
                columns: table => new
                {
                    RestrictedWebsiteId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestrictedWebsiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictedWebsites", x => x.RestrictedWebsiteId);
                    table.ForeignKey(
                        name: "FK_RestrictedWebsites_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "StaffingPlans",
                columns: table => new
                {
                    StaffingPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffingPlans", x => x.StaffingPlanId);
                    table.ForeignKey(
                        name: "FK_StaffingPlans_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ErpUser = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    EmploymentTypeId = table.Column<int>(type: "int", nullable: true),
                    ReportingAuthority = table.Column<long>(type: "bigint", nullable: true),
                    JobApplicantId = table.Column<long>(type: "bigint", nullable: true),
                    OfferDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoticePeriodDays = table.Column<int>(type: "int", nullable: true),
                    RetirementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationWithEmergencyContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiometricOrRfIdDeviceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvidentFundAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarraigeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportDateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportValidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportPlaceOfIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterFeedBackQuestions",
                columns: table => new
                {
                    InterFeedBackQuestionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterFeedBackQuestions", x => x.InterFeedBackQuestionsId);
                    table.ForeignKey(
                        name: "FK_InterFeedBackQuestions_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobOpenings",
                columns: table => new
                {
                    JobOpeningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryLowerRange = table.Column<double>(type: "float", nullable: true),
                    SalaryUpperRange = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpenings", x => x.JobOpeningId);
                    table.ForeignKey(
                        name: "FK_JobOpenings_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOpenings_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffingPlanDetails",
                columns: table => new
                {
                    StaffingPlanDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    NoOfVacancies = table.Column<int>(type: "int", nullable: false),
                    EstimatedCostPerPosition = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffingPlanDetails", x => x.StaffingPlanDetailsId);
                    table.ForeignKey(
                        name: "FK_StaffingPlanDetails_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAccounts",
                columns: table => new
                {
                    EmailAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<int>(type: "int", nullable: false),
                    EmailAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternativeEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefaultSending = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAccounts", x => x.EmailAccountId);
                    table.ForeignKey(
                        name: "FK_EmailAccounts_EmailDomains_Domain",
                        column: x => x.Domain,
                        principalTable: "EmailDomains",
                        principalColumn: "EmailDomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HolidayDays",
                columns: table => new
                {
                    HolidayDaysId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayId = table.Column<int>(type: "int", nullable: false),
                    ForDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayDays", x => x.HolidayDaysId);
                    table.ForeignKey(
                        name: "FK_HolidayDays_Holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "Holidays",
                        principalColumn: "HolidayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleAndApplicationWisePermissions",
                columns: table => new
                {
                    RoleAndApplicationWisePermissionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAndApplicationWisePermissions", x => x.RoleAndApplicationWisePermissionId);
                    table.ForeignKey(
                        name: "FK_RoleAndApplicationWisePermissions_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAndApplicationWisePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMappings",
                columns: table => new
                {
                    UserRoleMappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMappings", x => x.UserRoleMappingId);
                    table.ForeignKey(
                        name: "FK_UserRoleMappings_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMappings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWiseViewMappers",
                columns: table => new
                {
                    UserWiseViewMapperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWiseViewMappers", x => x.UserWiseViewMapperId);
                    table.ForeignKey(
                        name: "FK_UserWiseViewMappers_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWiseViewMappers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false),
                    TaxId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountManagerId = table.Column<long>(type: "bigint", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerGroups_CustomerGroupId",
                        column: x => x.CustomerGroupId,
                        principalTable: "CustomerGroups",
                        principalColumn: "CustomerGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Employees_AccountManagerId",
                        column: x => x.AccountManagerId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "DesktopActivityLogs",
                columns: table => new
                {
                    DesktopActivityLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesktopLoginId = table.Column<long>(type: "bigint", nullable: true),
                    LogDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessOrUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppOrWebPageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyncedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Todatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopActivityLogs", x => x.DesktopActivityLogId);
                    table.ForeignKey(
                        name: "FK_DesktopActivityLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopLogins",
                columns: table => new
                {
                    DesktopLoginId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    LoginDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LogOutDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAutoLogedOut = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveSession = table.Column<bool>(type: "bit", nullable: false),
                    IdelTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SyncedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopLogins", x => x.DesktopLoginId);
                    table.ForeignKey(
                        name: "FK_DesktopLogins_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEducationalQualifications",
                columns: table => new
                {
                    EmployeeEducationalQualificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    SchoolOrUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfPassing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEducationalQualifications", x => x.EmployeeEducationalQualificationId);
                    table.ForeignKey(
                        name: "FK_EmployeeEducationalQualifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EffortHourRequired = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompleteMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SalesOrderId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedCost = table.Column<double>(type: "float", nullable: true),
                    ProjectManager = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Employees_ProjectManager",
                        column: x => x.ProjectManager,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Projects_ProjectTypes_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "ProjectTypes",
                        principalColumn: "ProjectTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    JobApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobApplicationSourceId = table.Column<int>(type: "int", nullable: false),
                    TagDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryExpectation = table.Column<double>(type: "float", nullable: true),
                    SalaryExpectationLowerRange = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.JobApplicationId);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobApplicationSources_JobApplicationSourceId",
                        column: x => x.JobApplicationSourceId,
                        principalTable: "JobApplicationSources",
                        principalColumn: "JobApplicationSourceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobOpenings_JobId",
                        column: x => x.JobId,
                        principalTable: "JobOpenings",
                        principalColumn: "JobOpeningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesktopKeyStrokes",
                columns: table => new
                {
                    DesktopKeyStrokeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesktopActivityLogId = table.Column<long>(type: "bigint", nullable: true),
                    Keystrokes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyStrokeDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SyncedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopKeyStrokes", x => x.DesktopKeyStrokeId);
                    table.ForeignKey(
                        name: "FK_DesktopKeyStrokes_DesktopActivityLogs_DesktopActivityLogId",
                        column: x => x.DesktopActivityLogId,
                        principalTable: "DesktopActivityLogs",
                        principalColumn: "DesktopActivityLogId");
                });

            migrationBuilder.CreateTable(
                name: "DesktopSnapshots",
                columns: table => new
                {
                    DesktopSnapshotId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesktopActivityLogId = table.Column<long>(type: "bigint", nullable: true),
                    DesktopLoginId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SnapShot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SnapshotDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileSize = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopSnapshots", x => x.DesktopSnapshotId);
                    table.ForeignKey(
                        name: "FK_DesktopSnapshots_DesktopActivityLogs_DesktopActivityLogId",
                        column: x => x.DesktopActivityLogId,
                        principalTable: "DesktopActivityLogs",
                        principalColumn: "DesktopActivityLogId");
                });

            migrationBuilder.CreateTable(
                name: "ProjectEmployees",
                columns: table => new
                {
                    ProjectEmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectEmployees", x => x.ProjectEmployeeId);
                    table.ForeignKey(
                        name: "FK_ProjectEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectEmployees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    AssignedBy = table.Column<long>(type: "bigint", nullable: true),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTaskId = table.Column<long>(type: "bigint", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedTimeInHours = table.Column<double>(type: "float", nullable: true),
                    Progress = table.Column<double>(type: "float", nullable: true),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplitedBy = table.Column<long>(type: "bigint", nullable: true),
                    ComplitedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskComplitedByOthersReasonByAssign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskComplitedByOthersReasonByComplitedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelayApproved = table.Column<int>(type: "int", nullable: true),
                    DelayReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelayApprovedBy = table.Column<long>(type: "bigint", nullable: true),
                    DelayApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DelayApprovalReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalHoursByTimeSheet = table.Column<double>(type: "float", nullable: true),
                    TotalBillableHourByTimeSheet = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.ProjectTaskId);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Employees_ComplitedBy",
                        column: x => x.ComplitedBy,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUsers",
                columns: table => new
                {
                    ProjectUserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUsers", x => x.ProjectUserId);
                    table.ForeignKey(
                        name: "FK_ProjectUsers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskAssignment",
                columns: table => new
                {
                    TaskAssignmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    AssignedBy = table.Column<long>(type: "bigint", nullable: true),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompliteBy = table.Column<long>(type: "bigint", nullable: true),
                    ActualCompliteOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DelayReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelayApproved = table.Column<bool>(type: "bit", nullable: true),
                    DelayApprovedBy = table.Column<long>(type: "bigint", nullable: true),
                    DelayApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAssignment", x => x.TaskAssignmentId);
                    table.ForeignKey(
                        name: "FK_TaskAssignment_Employees_AssignedBy",
                        column: x => x.AssignedBy,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_TaskAssignment_Employees_CompliteBy",
                        column: x => x.CompliteBy,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_TaskAssignment_Employees_DelayApprovedBy",
                        column: x => x.DelayApprovedBy,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_TaskAssignment_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAssignment_ProjectTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "ProjectTaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timesheets",
                columns: table => new
                {
                    TimesheetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    TimeSheetForDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimesheetActivityType = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    OpportunityId = table.Column<int>(type: "int", nullable: true),
                    TaskId = table.Column<long>(type: "bigint", nullable: true),
                    FromTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ToTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    DurationInHours = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBillable = table.Column<bool>(type: "bit", nullable: false),
                    HourlyRate = table.Column<double>(type: "float", nullable: true),
                    TimeSheetApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    TimesheetApprovedBy = table.Column<long>(type: "bigint", nullable: true),
                    TimeSheetApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeSheetApprovalRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheets", x => x.TimesheetId);
                    table.ForeignKey(
                        name: "FK_Timesheets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timesheets_Employees_TimesheetApprovedBy",
                        column: x => x.TimesheetApprovedBy,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Timesheets_ProjectActivityTypes_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "ProjectActivityTypes",
                        principalColumn: "ProjectActivityTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timesheets_ProjectTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "ProjectTaskId");
                    table.ForeignKey(
                        name: "FK_Timesheets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                    table.ForeignKey(
                        name: "FK_Timesheets_TimesheetActivityCategories_TimesheetActivityType",
                        column: x => x.TimesheetActivityType,
                        principalTable: "TimesheetActivityCategories",
                        principalColumn: "TimesheetActivityCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "AccountTypeId", "AccountTypeName", "CreatedBy", "CreatedDate", "Deleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Accumulated Depreciation", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4806), false, null, null },
                    { 2, "Asset Received But Not Billed", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4809), false, null, null },
                    { 3, "Bank", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4810), false, null, null },
                    { 4, "Cash", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4811), false, null, null },
                    { 5, "Chargeable", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4813), false, null, null },
                    { 6, "Capital Work in Progress", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4814), false, null, null },
                    { 7, "Cost of Goods Sold", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4815), false, null, null },
                    { 8, "Depreciation", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4816), false, null, null },
                    { 9, "Equity", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4818), false, null, null },
                    { 10, "Expense Account", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4819), false, null, null },
                    { 11, "Expenses Included In Asset Valuation", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4820), false, null, null },
                    { 12, "Expenses Included In Valuation", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4821), false, null, null },
                    { 13, "Fixed Asset", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4822), false, null, null },
                    { 14, "Income Account", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4823), false, null, null },
                    { 15, "Payable", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4824), false, null, null },
                    { 16, "Receivable", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4825), false, null, null },
                    { 17, "Round Off", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4826), false, null, null },
                    { 18, "Stock", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4828), false, null, null },
                    { 19, "Stock Adjustment", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4829), false, null, null },
                    { 20, "Stock Received But Not Billed", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4830), false, null, null },
                    { 21, "Service Received But Not Billed", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4831), false, null, null },
                    { 22, "Tax", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4833), false, null, null },
                    { 23, "Temporary", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4834), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "ApplicationId1", "ApplicationName", "AreaName", "CreatedBy", "CreatedDate", "Deleted", "IconClass", "IconImageUrl", "IsGroup", "Parent", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1, null, "Applications", "Application", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3088), false, null, "/appstatic/images/applications.png", true, null, null, null, "/Application/Applications/InstalledApps" },
                    { 2, null, "Setup", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3094), false, null, "/appstatic/images/setup.png", true, null, null, null, "/Setup/Setup/Dashboard" },
                    { 3, null, "Company Settings", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3096), false, null, null, true, 2, null, null, "" },
                    { 4, null, "Company", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3097), false, null, null, false, 3, null, null, "/Setup/CompanyDetails/CompanyDetailsView" },
                    { 5, null, "Letter Head", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3099), false, null, null, false, 3, null, null, "/Setup/LetterHead/LetterHeadView" },
                    { 6, null, "User", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3101), false, null, null, true, 2, null, null, "" },
                    { 7, null, "User List", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3102), false, null, null, false, 6, null, null, "/Setup/User/UserList" },
                    { 8, null, "Email Setup", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3104), false, null, null, true, 2, null, null, "" },
                    { 9, null, "Domain", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3105), false, null, null, true, 8, null, null, "/Setup/EmailDomain/EmailDomainView" },
                    { 10, null, "Email Account", "Setup", 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3107), false, null, null, true, 8, null, null, "/Setup/EmailAccount/EmailAccountView" }
                });

            migrationBuilder.InsertData(
                table: "ChartOfAccounts",
                columns: new[] { "ChartOfAccountsId", "AccountName", "AccountNumber", "AccountType", "BalanceMustBe", "ChartOfAccountsId1", "CreatedBy", "CreatedDate", "Deleted", "IsGroup", "ParentAccountGroupId", "ReportType", "RootType", "TaxRate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Application of Funds (Assets)", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5026), false, true, null, "Balance Sheet", "Assets", null, null, null },
                    { 2, "Current Assets", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5030), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 3, "Accounts Receivable", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5032), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 4, "Debtors", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5034), false, false, 3, "Balance Sheet", "Assets", null, null, null },
                    { 5, "Bank Accounts", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5036), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 6, "Cash In Hand", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5038), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 7, "Cash", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5040), false, false, 6, "Balance Sheet", "Assets", null, null, null },
                    { 8, "Loans and Advances (Assets)", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5042), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 9, "Securities and Deposits", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5044), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 10, "Earnest Money", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5047), false, false, 9, "Balance Sheet", "Assets", null, null, null },
                    { 11, "Stock Assets", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5049), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 12, "Stock In Hand", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5051), false, false, 11, "Balance Sheet", "Assets", null, null, null },
                    { 13, "Tax Assets", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5053), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 14, "Fixed Assets", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5055), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 15, "Accumulated Depreciations", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5056), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 16, "Accumulated Depreciations", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5058), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 17, "Buildings", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5060), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 18, "Capital Equipments", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5062), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 19, "Electronic Equipments", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5065), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 20, "Furnitures and Fixtures", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5067), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 21, "Office Equipments", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5069), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 22, "Plants and Machineries", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5071), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 23, "Investments", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5072), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 24, "Temporary Accounts", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5074), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 25, "Temporary Opening", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5076), false, false, 24, "Balance Sheet", "Assets", null, null, null },
                    { 26, "Source of Funds (Liabilities)", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5078), false, true, null, "Balance Sheet", "Liability", null, null, null },
                    { 27, "Capital Account", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5081), false, true, 26, "Balance Sheet", "Liability", null, null, null },
                    { 28, "Reserves and Surplus", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5083), false, false, 27, "Balance Sheet", "Liability", null, null, null },
                    { 29, "Shareholders Funds", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5085), false, false, 27, "Balance Sheet", "Liability", null, null, null },
                    { 30, "Current Liabilities", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5087), false, true, 26, "Balance Sheet", "Liability", null, null, null },
                    { 31, "Accounts Payable", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5089), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 32, "Creditors", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5091), false, false, 31, "Balance Sheet", "Liability", null, null, null },
                    { 33, "Payroll Payable", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5092), false, false, 31, "Balance Sheet", "Liability", null, null, null },
                    { 34, "Duties and Taxes", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5094), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 35, "TDS", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5096), false, false, 34, "Balance Sheet", "Liability", null, null, null },
                    { 36, "Loans (Liabilities)", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5098), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 37, "Bank Overdraft Account", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5101), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 38, "Secured Loans", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5103), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 39, "Unsecured Loans", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5104), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 40, "Stock Liabilities", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5106), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 41, "Stock Received But Not Billed", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5108), false, false, 40, "Balance Sheet", "Liability", null, null, null },
                    { 42, "Income", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5110), false, true, null, "Profit and Loss", "Income", null, null, null },
                    { 43, "Direct Income", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5112), false, true, 42, "Profit and Loss", "Income", null, null, null },
                    { 44, "Sales", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5148), false, false, 43, "Profit and Loss", "Income", null, null, null },
                    { 45, "Service", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5150), false, false, 43, "Profit and Loss", "Income", null, null, null },
                    { 46, "Indirect Income", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5154), false, true, 42, "Profit and Loss", "Income", null, null, null },
                    { 47, "Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5155), false, true, null, "Profit and Loss", "Expense", null, null, null },
                    { 48, "Direct Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5157), false, true, 47, "Profit and Loss", "Expense", null, null, null },
                    { 49, "Stock Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5159), false, true, 48, "Profit and Loss", "Expense", null, null, null },
                    { 50, "Cost of Goods Sold", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5161), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 51, "Expenses Included In Valuation", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5163), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 52, "Stock Adjustment", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5165), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 53, "Indirect Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5167), false, true, 47, "Profit and Loss", "Expense", null, null, null },
                    { 54, "Administrative Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5169), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 55, "Commission on Sales", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5171), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 56, "Depreciation", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5174), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 57, "Entertainment Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5175), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 58, "Exchange Gain/Loss", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5177), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 59, "Freight and Forwarding Charges", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5179), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 60, "Gain/Loss on Asset Disposal", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5181), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 61, "Legal Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5183), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 62, "Marketing Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5185), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 63, "Miscellaneous Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5187), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 64, "Office Maintenance Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5189), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 65, "Office Rent", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5192), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 66, "Postal Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5194), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 67, "Print and Stationary", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5196), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 68, "Rounded Off", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5197), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 69, "Salary", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5199), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 70, "Sales Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5201), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 71, "Telephone Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5203), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 72, "Travel Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5205), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 73, "Utility Expenses", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5207), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 74, "Write Off", null, null, null, null, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5209), false, false, 53, "Profit and Loss", "Expense", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateId", "CreatedBy", "CreatedDate", "DefaultSendingAccount", "Deleted", "EmailTemplateDescription", "EmailTemplateName", "Subject", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4666), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\">\r\n                                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">{%welcometitle%} </h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\">\r\n                                                            <table border=\"0\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <h5 style=\"font-weight:400; margin-bottom:0; font-size:16px; color:#676767\"><span style=\"color:rgb(22,123,158); font-size:16px; margin-right:2px; font-weight:600\"></span>{%helloname%}</h5>\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%accountcreatetionmessage%}</p>\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%loginidmessage%}</p>\r\n\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">{%aditionalmessage%}</p>\r\n                                                                                <div style=\"margin:20px 0 0 0; text-align:center\">{%setpasswordlink%}</div>\r\n                                                                                <br />\r\n                                                                                {%copylinkfrommessage%}\r\n                                                                            </div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table border=\"0\" style=\"width:100%\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table border=\"0\" style=\"width:100%\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"></div> </div></span>\r\n</div>", "WelcomeEmail", "", null, null });

            migrationBuilder.InsertData(
                table: "HRSettings",
                columns: new[] { "HRSettingsId", "BreakHours", "CreatedBy", "Deleted", "RetirementAge", "SendBirthdaysReminder", "SendInterviewFeedbackReminder", "SendInterviewReminder", "SendWorkAnniversariesReminder", "StandardWorkingHours", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 60.0, 1L, false, 60, true, true, true, true, 9.0, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedDate", "Deleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(1075), false, "Administrator", null, null });

            migrationBuilder.InsertData(
                table: "TimesheetActivityCategories",
                columns: new[] { "TimesheetActivityCategoryId", "CreatedBy", "CreatedDate", "Deleted", "TimesheetActivityCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5514), false, "Project Work", null, null },
                    { 2, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5516), false, "Counselling /Discussion", null, null },
                    { 3, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5517), false, "Documentation/Report/Policy/SOP/MIS", null, null },
                    { 4, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5518), false, "Event Management & Participation", null, null },
                    { 5, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5519), false, "Imaginar", null, null },
                    { 6, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5521), false, "Interviews", null, null },
                    { 7, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5522), false, "Project & Process Audit", null, null },
                    { 8, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5523), false, "Review & Monitor/Report Analysis/Meetings", null, null },
                    { 9, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5524), false, "RFP Response", null, null },
                    { 10, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5525), false, "Project Work", null, null },
                    { 11, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5526), false, "R&D", null, null },
                    { 12, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5528), false, "Project (CSR)", null, null },
                    { 13, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5529), false, "Project (Product)", null, null },
                    { 14, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5530), false, "Townhall", null, null },
                    { 15, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5531), false, "Quality Review", null, null },
                    { 16, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5533), false, "Performance Assessment", null, null },
                    { 17, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5534), false, "Induction/knowledge sharing", null, null },
                    { 18, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5535), false, "Training & Capacity Building", null, null },
                    { 19, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5536), false, "Annual function", null, null },
                    { 20, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5537), false, "Meetings & Reviews", null, null },
                    { 21, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5538), false, "Travel for office Tour", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedBy", "CreatedDate", "DateOfBirth", "Deleted", "Email", "FailedLoginAttempts", "FirstName", "IsActive", "LastActivityDate", "LastIpAddress", "LastLoginDate", "LastName", "MiddleName", "Password", "PhoneNo", "ResetPasswordToken", "ResetPasswordTokenExpirey", "UpdatedBy", "UpdatedDate", "UserType", "UserTypeId" },
                values: new object[] { 1L, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(2264), null, false, "admin@appman.in", null, "Administrator", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", null, "r9NmU79/NE0x0el2cuI8PeI4GlVCdpOeB875sWPUeJw=", "9583000000", null, null, null, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "RoleAndApplicationWisePermissions",
                columns: new[] { "RoleAndApplicationWisePermissionId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "RoleId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3729), false, 1, null, null },
                    { 2L, 2, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3733), false, 1, null, null },
                    { 3L, 3, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3734), false, 1, null, null },
                    { 4L, 4, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3735), false, 1, null, null },
                    { 5L, 5, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3737), false, 1, null, null },
                    { 6L, 6, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3738), false, 1, null, null },
                    { 7L, 7, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3740), false, 1, null, null },
                    { 8L, 8, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3741), false, 1, null, null },
                    { 9L, 9, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3742), false, 1, null, null },
                    { 10L, 10, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3744), false, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoleMappings",
                columns: new[] { "UserRoleMappingId", "RoleId", "UserId" },
                values: new object[] { 1, 1, 1L });

            migrationBuilder.InsertData(
                table: "UserWiseViewMappers",
                columns: new[] { "UserWiseViewMapperId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 1, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4404), false, null, null, 1L },
                    { 2L, 2, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4408), false, null, null, 1L },
                    { 3L, 3, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4410), false, null, null, 1L },
                    { 4L, 4, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4412), false, null, null, 1L },
                    { 5L, 5, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4413), false, null, null, 1L },
                    { 6L, 6, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4414), false, null, null, 1L },
                    { 7L, 7, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4416), false, null, null, 1L },
                    { 8L, 8, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4424), false, null, null, 1L },
                    { 9L, 9, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4431), false, null, null, 1L },
                    { 10L, 10, 1L, new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4433), false, null, null, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationId1",
                table: "Applications",
                column: "ApplicationId1");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOfAccounts_ChartOfAccountsId1",
                table: "ChartOfAccounts",
                column: "ChartOfAccountsId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountManagerId",
                table: "Customers",
                column: "AccountManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerGroupId",
                table: "Customers",
                column: "CustomerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentId1",
                table: "Departments",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopActivityLogs_EmployeeId",
                table: "DesktopActivityLogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopKeyStrokes_DesktopActivityLogId",
                table: "DesktopKeyStrokes",
                column: "DesktopActivityLogId");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopLogins_EmployeeId",
                table: "DesktopLogins",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DesktopSnapshots_DesktopActivityLogId",
                table: "DesktopSnapshots",
                column: "DesktopActivityLogId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAccounts_Domain",
                table: "EmailAccounts",
                column: "Domain");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducationalQualifications_EmployeeId",
                table: "EmployeeEducationalQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationId",
                table: "Employees",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayDays_HolidayId",
                table: "HolidayDays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_InterFeedBackQuestions_DesignationId",
                table: "InterFeedBackQuestions",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobApplicationSourceId",
                table: "JobApplications",
                column: "JobApplicationSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobId",
                table: "JobApplications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_DepartmentId",
                table: "JobOpenings",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_DesignationId",
                table: "JobOpenings",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEmployees_EmployeeId",
                table: "ProjectEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectEmployees_ProjectId",
                table: "ProjectEmployees",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectManager",
                table: "Projects",
                column: "ProjectManager");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ComplitedBy",
                table: "ProjectTasks",
                column: "ComplitedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_EmployeeId",
                table: "ProjectTasks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectId",
                table: "ProjectTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUsers_ProjectId",
                table: "ProjectUsers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUsers_UserId",
                table: "ProjectUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RestrictedApplications_DepartmentId",
                table: "RestrictedApplications",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RestrictedWebsites_DepartmentId",
                table: "RestrictedWebsites",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAndApplicationWisePermissions_ApplicationId",
                table: "RoleAndApplicationWisePermissions",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAndApplicationWisePermissions_RoleId",
                table: "RoleAndApplicationWisePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffingPlanDetails_DesignationId",
                table: "StaffingPlanDetails",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffingPlans_DepartmentId",
                table: "StaffingPlans",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignment_AssignedBy",
                table: "TaskAssignment",
                column: "AssignedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignment_CompliteBy",
                table: "TaskAssignment",
                column: "CompliteBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignment_DelayApprovedBy",
                table: "TaskAssignment",
                column: "DelayApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignment_EmployeeId",
                table: "TaskAssignment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssignment_TaskId",
                table: "TaskAssignment",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_ActivityId",
                table: "Timesheets",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_EmployeeId",
                table: "Timesheets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_ProjectId",
                table: "Timesheets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_TaskId",
                table: "Timesheets",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_TimesheetActivityType",
                table: "Timesheets",
                column: "TimesheetActivityType");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_TimesheetApprovedBy",
                table: "Timesheets",
                column: "TimesheetApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMappings_RoleId",
                table: "UserRoleMappings",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMappings_UserId",
                table: "UserRoleMappings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWiseViewMappers_ApplicationId",
                table: "UserWiseViewMappers",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWiseViewMappers_UserId",
                table: "UserWiseViewMappers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "ActivityLogTypes");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "ChartOfAccounts");

            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DesktopKeyStrokes");

            migrationBuilder.DropTable(
                name: "DesktopLogins");

            migrationBuilder.DropTable(
                name: "DesktopSnapshots");

            migrationBuilder.DropTable(
                name: "EmailAccounts");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "EmployeeEducationalQualifications");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "FinancialYear");

            migrationBuilder.DropTable(
                name: "HolidayDays");

            migrationBuilder.DropTable(
                name: "HRSettings");

            migrationBuilder.DropTable(
                name: "InstalledApplications");

            migrationBuilder.DropTable(
                name: "InterFeedBackQuestions");

            migrationBuilder.DropTable(
                name: "InterviewTypes");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "LetterHeads");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "ProjectEmployees");

            migrationBuilder.DropTable(
                name: "ProjectUsers");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "RestrictedApplications");

            migrationBuilder.DropTable(
                name: "RestrictedWebsites");

            migrationBuilder.DropTable(
                name: "RoleAndApplicationWisePermissions");

            migrationBuilder.DropTable(
                name: "ShiftTypes");

            migrationBuilder.DropTable(
                name: "StaffingPlanDetails");

            migrationBuilder.DropTable(
                name: "StaffingPlans");

            migrationBuilder.DropTable(
                name: "TaskAssignment");

            migrationBuilder.DropTable(
                name: "Timesheets");

            migrationBuilder.DropTable(
                name: "UserRoleMappings");

            migrationBuilder.DropTable(
                name: "UserWiseViewMappers");

            migrationBuilder.DropTable(
                name: "CustomerGroups");

            migrationBuilder.DropTable(
                name: "DesktopActivityLogs");

            migrationBuilder.DropTable(
                name: "EmailDomains");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "JobApplicationSources");

            migrationBuilder.DropTable(
                name: "JobOpenings");

            migrationBuilder.DropTable(
                name: "ProjectActivityTypes");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "TimesheetActivityCategories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ProjectTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Designations");
        }
    }
}
