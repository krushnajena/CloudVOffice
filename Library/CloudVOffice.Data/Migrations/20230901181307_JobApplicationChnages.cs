using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class JobApplicationChnages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillSetId",
                table: "JobOpenings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OfferAccepteddOn",
                table: "JobApplications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OfferRejectedOn",
                table: "JobApplications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfferRejecttionReason",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RejectedInInterviewRoundId",
                table: "JobApplications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "JobApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 23, 43, 6, 589, DateTimeKind.Local).AddTicks(1784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillSetId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "OfferAccepteddOn",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "OfferRejectedOn",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "OfferRejecttionReason",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "RejectedInInterviewRoundId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "JobApplications");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 613, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 1, 15, 32, 50, 612, DateTimeKind.Local).AddTicks(7184));
        }
    }
}
