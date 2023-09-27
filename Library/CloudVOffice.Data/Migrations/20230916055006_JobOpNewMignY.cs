using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class JobOpNewMignY : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_Departments_DepartmentId",
                table: "JobOpenings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_Designations_DesignationId",
                table: "JobOpenings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_SkillSets_SkillSetId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_DepartmentId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_DesignationId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_SkillSetId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "JobOpenings");

            migrationBuilder.RenameColumn(
                name: "SkillSetId",
                table: "JobOpenings",
                newName: "JobOpType");

            migrationBuilder.RenameColumn(
                name: "SalaryUpperRange",
                table: "JobOpenings",
                newName: "RevenuePerPosition");

            migrationBuilder.RenameColumn(
                name: "SalaryLowerRange",
                table: "JobOpenings",
                newName: "ExpectedRevenue");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "JobOpenings",
                newName: "WorkExperience");

            migrationBuilder.AddColumn<double>(
                name: "ActualRevenue",
                table: "JobOpenings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Benefits",
                table: "JobOpenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobOpenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "JobOpenings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContactId",
                table: "JobOpenings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOpened",
                table: "JobOpenings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HiringManagerId",
                table: "JobOpenings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "JobOpenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "JobOpenings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberofPositions",
                table: "JobOpenings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PublishOnWebsite",
                table: "JobOpenings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "JobOpenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetDate",
                table: "JobOpenings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 776, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 777, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 16, 11, 20, 5, 776, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_ContactId",
                table: "JobOpenings",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_HiringManagerId",
                table: "JobOpenings",
                column: "HiringManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_Employees_HiringManagerId",
                table: "JobOpenings",
                column: "HiringManagerId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_RecruitClientContacts_ContactId",
                table: "JobOpenings",
                column: "ContactId",
                principalTable: "RecruitClientContacts",
                principalColumn: "RecruitClientContactId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_Employees_HiringManagerId",
                table: "JobOpenings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_RecruitClientContacts_ContactId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_ContactId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_HiringManagerId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "ActualRevenue",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "Benefits",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "DateOpened",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "HiringManagerId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "NumberofPositions",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "PublishOnWebsite",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "TargetDate",
                table: "JobOpenings");

            migrationBuilder.RenameColumn(
                name: "WorkExperience",
                table: "JobOpenings",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "RevenuePerPosition",
                table: "JobOpenings",
                newName: "SalaryUpperRange");

            migrationBuilder.RenameColumn(
                name: "JobOpType",
                table: "JobOpenings",
                newName: "SkillSetId");

            migrationBuilder.RenameColumn(
                name: "ExpectedRevenue",
                table: "JobOpenings",
                newName: "SalaryLowerRange");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "JobOpenings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignationId",
                table: "JobOpenings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 8, 0, 33, 29, 205, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_DepartmentId",
                table: "JobOpenings",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_DesignationId",
                table: "JobOpenings",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_SkillSetId",
                table: "JobOpenings",
                column: "SkillSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_Departments_DepartmentId",
                table: "JobOpenings",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_Designations_DesignationId",
                table: "JobOpenings",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_SkillSets_SkillSetId",
                table: "JobOpenings",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "SkillSetId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
