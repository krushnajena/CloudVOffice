using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class CA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChartOfAccounts_ChartOfAccounts_ChartOfAccountsId1",
                table: "ChartOfAccounts");

            migrationBuilder.DropIndex(
                name: "IX_ChartOfAccounts_ChartOfAccountsId1",
                table: "ChartOfAccounts");

            migrationBuilder.DropColumn(
                name: "ChartOfAccountsId1",
                table: "ChartOfAccounts");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 14, 49, 59, 646, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.CreateIndex(
                name: "IX_ChartOfAccounts_ParentAccountGroupId",
                table: "ChartOfAccounts",
                column: "ParentAccountGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChartOfAccounts_ChartOfAccounts_ParentAccountGroupId",
                table: "ChartOfAccounts",
                column: "ParentAccountGroupId",
                principalTable: "ChartOfAccounts",
                principalColumn: "ChartOfAccountsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChartOfAccounts_ChartOfAccounts_ParentAccountGroupId",
                table: "ChartOfAccounts");

            migrationBuilder.DropIndex(
                name: "IX_ChartOfAccounts_ParentAccountGroupId",
                table: "ChartOfAccounts");

            migrationBuilder.AddColumn<int>(
                name: "ChartOfAccountsId1",
                table: "ChartOfAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                columns: new[] { "ChartOfAccountsId1", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 12, 3, 49, 162, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.CreateIndex(
                name: "IX_ChartOfAccounts_ChartOfAccountsId1",
                table: "ChartOfAccounts",
                column: "ChartOfAccountsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ChartOfAccounts_ChartOfAccounts_ChartOfAccountsId1",
                table: "ChartOfAccounts",
                column: "ChartOfAccountsId1",
                principalTable: "ChartOfAccounts",
                principalColumn: "ChartOfAccountsId");
        }
    }
}
