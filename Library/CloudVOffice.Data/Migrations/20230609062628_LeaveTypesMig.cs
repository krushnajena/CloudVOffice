using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class LeaveTypesMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialYears",
                table: "FinancialYears");

            migrationBuilder.DropColumn(
                name: "ActivityCategory",
                table: "ProjectActivityTypes");

            migrationBuilder.RenameTable(
                name: "FinancialYears",
                newName: "FinancialYear");

            migrationBuilder.AlterColumn<int>(
                name: "TimesheetActivityType",
                table: "Timesheets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ActivityCategoryId",
                table: "ProjectActivityTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialYear",
                table: "FinancialYear",
                column: "FinancialYearId");

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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.HolidayId);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.LeaveTypeId);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 543, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.InsertData(
                table: "TimesheetActivityCategories",
                columns: new[] { "TimesheetActivityCategoryId", "CreatedBy", "CreatedDate", "Deleted", "TimesheetActivityCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3460), false, "Project Work", null, null },
                    { 2, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3462), false, "Counselling /Discussion", null, null },
                    { 3, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3464), false, "Documentation/Report/Policy/SOP/MIS", null, null },
                    { 4, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3465), false, "Event Management & Participation", null, null },
                    { 5, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3466), false, "Imaginar", null, null },
                    { 6, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3468), false, "Interviews", null, null },
                    { 7, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3470), false, "Project & Process Audit", null, null },
                    { 8, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3471), false, "Review & Monitor/Report Analysis/Meetings", null, null },
                    { 9, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3472), false, "RFP Response", null, null },
                    { 10, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3473), false, "Project Work", null, null },
                    { 11, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3474), false, "R&D", null, null },
                    { 12, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3475), false, "Project (CSR)", null, null },
                    { 13, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3477), false, "Project (Product)", null, null },
                    { 14, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3478), false, "Townhall", null, null },
                    { 15, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3479), false, "Quality Review", null, null },
                    { 16, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3480), false, "Performance Assessment", null, null },
                    { 17, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3481), false, "Induction/knowledge sharing", null, null },
                    { 18, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3482), false, "Training & Capacity Building", null, null },
                    { 19, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3484), false, "Annual function", null, null },
                    { 20, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3485), false, "Meetings & Reviews", null, null },
                    { 21, 1L, new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(3486), false, "Travel for office Tour", null, null }
                });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 544, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 9, 11, 56, 27, 543, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.CreateIndex(
                name: "IX_HolidayDays_HolidayId",
                table: "HolidayDays",
                column: "HolidayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HolidayDays");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialYear",
                table: "FinancialYear");

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "ActivityCategoryId",
                table: "ProjectActivityTypes");

            migrationBuilder.RenameTable(
                name: "FinancialYear",
                newName: "FinancialYears");

            migrationBuilder.AlterColumn<string>(
                name: "TimesheetActivityType",
                table: "Timesheets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ActivityCategory",
                table: "ProjectActivityTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialYears",
                table: "FinancialYears",
                column: "FinancialYearId");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 933, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 917, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 21, 8, 45, 932, DateTimeKind.Local).AddTicks(6294));
        }
    }
}
