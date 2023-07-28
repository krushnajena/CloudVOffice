using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmailTemplatesMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EffortHourRequired",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateId", "CreatedBy", "CreatedDate", "DefaultSendingAccount", "Deleted", "EmailTemplateDescription", "EmailTemplateName", "Subject", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 1L, new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9126), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\" class=\"e-rte-table\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\" class=\"\">\r\n                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\" class=\"e-rte-table\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td><br></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\" class=\"\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">Project Assignment Notification</h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\">\r\n                                                            <table class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td class=\"\" style=\"vertical-align: top;\">\r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <h5 style=\"font-weight:400; margin-bottom:0; font-size:16px; color:#676767\">Hello {%helloname%},</h5>\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">we hope this message finds you well.we are delighted to inform you</p><p><span style=\"background-color: transparent; text-align: inherit;\">that you have been assigned to a new project in our organization. This project is an essential inititative for our company's growth, and we are confident that your skills and expertise will play crucial role in its success.</span><br></p><p><span style=\"background-color: transparent; text-align: inherit;\"><br></span></p><p><span style=\"background-color: transparent; text-align: inherit;\">Project Details:</span></p>\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">Project Name: {%ProjectName%}</p><p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">Project Id:&nbsp;<span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">{%projectid%}</span></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Project Duration:<span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">{%startdate%} to&nbsp;<span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">{%enddate%}</span></span></span></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Project Manager:<span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">{%projectmanagername%}</span></span></span></span></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Project Description:<span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">{%projectdescription%}</span></span></span></span></span></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 16px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\"><br></span></span></span></span></span></p></div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"><br></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"><br></div> </div></span>\r\n</div>", "ProjectAssignment", "Project Assignment - {%ProjectName%}", null, null },
                    { 3, 1L, new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9128), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\" class=\"e-rte-table\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\">\r\n                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\" class=\"e-rte-table\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td><br></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\" class=\"\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">Project Un-Assignment</h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\" class=\"\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\" class=\"\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\" class=\"\"><br><table class=\"e-rte-table\" style=\"max-width: 1356.5px;\"><tbody><tr><td class=\"\"><div style=\"margin-left:1.2rem; margin-bottom:1em\"><p>Hello {%Name%}</p><p>I hope this email finds you well. We are writing to inform you about a recent change in project assignments within our organization. Regrettably, you have been un-assigned from the following project:</p>\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">Project Name: {%ProjectName%}</p>\r\n\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">Project Id: {%ProjectId%}</p><p><br></p>\r\n\r\n\r\n                                                                                <p>The decision to un-assign you from this project was made based on [reason for un-assignment, e.g., changes in project requirements, resource reallocation, etc.]. We understand that you may have invested time and effort into this project, and we appreciate your dedication.</p><p>Your un-assignment from this project does not reflect on your capabilities or commitment to our organization. We value your skills and contributions and look forward to involving you in future projects that align with your expertise.</p></div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"><br></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"><br></div> </div></span>\r\n</div>", "ProjectUn-Assignment", "Project Un-Assignment - {%ProjectName%}", null, null },
                    { 4, 1L, new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9129), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\" class=\"e-rte-table\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\" class=\"\">\r\n                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\" class=\"e-rte-table\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td><br></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\" class=\"\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">Timesheet Updation | Reminder!</h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\" class=\"\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\" class=\"\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\" class=\"\"><br><table class=\"e-rte-table\" style=\"max-width: 1356.5px;\"><tbody><tr><td class=\"\"><div style=\"margin-left:1.2rem; margin-bottom:1em\"><p>Hello {%Name%}</p><p style=\"font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;\">This is a reminder that your timesheet updation is pending for:<span style=\"background-color: transparent; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; text-align: inherit;\">&nbsp;<strong>{%Date%}</strong></span></p><p style=\"font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;\">Please log into {%appname%} to update your timesheet.</p><p style=\"font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;\"><br></p><p style=\"font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;\">Failure to submit your timesheets may result in loss of Earned Leave (EL) or loss of pay.</p><p style=\"font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); color: rgb(103, 103, 103); line-height: 23.2px; font-size: 16px; margin: 5px 0px !important;\">If you have any questions regarding your Timesheet then please contact your Reporting Authority/Project Manager.</p></div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"><br></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"><br></div> </div></span>\r\n</div>", "TimesheetReminder", "Timesheet Updation | Reminder!", null, null },
                    { 5, 1L, new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9130), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\" class=\"e-rte-table\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\" class=\"\">\r\n                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\" class=\"e-rte-table\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td><br></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\" class=\"\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">Task Overdue</h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\" class=\"\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\" class=\"\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\" class=\"\"><br><table class=\"e-rte-table\" style=\"max-width: 1356.5px;\"><tbody><tr><td class=\"\"><div style=\"margin-left:1.2rem; margin-bottom:1em\"><p>Hello {%Name%}</p><p>I hope this email finds you well. We would like to bring to your attention that there is an overdue task assigned to you with the following details:</p><p>Task Name : {%TaskName%}</p><p>Task Id : {%TaskId%}</p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Due Date : {%DueDate%}</span><br></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Project Name : {%ProjectName%}</span><br></p><p>Project Id : {%ProjectId%}</p><p>As of today, {%CurrentDate%}, the task remains incomplete and is past its due date. We understand that unforeseen circumstances may arise, leading to delays. However, it is crucial to address overdue tasks promptly to maintain project timelines and overall efficiency.</p><p><span style=\"background-color: transparent; text-align: inherit;\">We kindly request you to prioritize this task and take immediate action to complete it as soon as possible. If you have encountered any obstacles or require additional resources to complete the task, please discuss with your Project Manager.</span><br></p></div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"><br></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"><br></div> </div></span>\r\n</div>", "TaskOverdue", "Task Overdue", null, null },
                    { 6, 1L, new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9131), null, false, "<div role=\"document\">\r\n    <div class=\"_rp_T4 _rp_U4 ms-font-weight-regular ms-font-color-neutralDark\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_w\" class=\"_rp_T4\" style=\"display: none;\"><br></div>  <div autoid=\"_rp_x\" class=\"_rp_T4\" id=\"Item.MessagePartBody\" style=\"\">\r\n        <div class=\"_rp_U4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass\" id=\"Item.MessageUniqueBody\" style=\"font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;\">\r\n            <div class=\"rps_ad57\">\r\n                <div>\r\n                    <div>\r\n                        <div style=\"margin: 0px; padding: 0px; font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; color: rgb(103, 103, 103);\">\r\n                            <table cellpadding=\"0\" cellspacing=\"0\" style=\"padding-top:0px; background-color:#FFFFFF; width:100%; border-collapse:separate\" class=\"e-rte-table\">\r\n                                <tbody>\r\n                                    <tr>\r\n                                        <td align=\"center\" class=\"\">\r\n                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"padding:0px 24px 10px; background-color:white; border-collapse:separate; border:1px solid #e7e7e7; border-bottom:none\" class=\"e-rte-table\">\r\n                                                <tbody>\r\n                                                    <tr>\r\n                                                        <td><br></td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td align=\"center\" style=\"min-width:590px\">\r\n                                                            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"padding:20px 0 0; border-collapse:separate\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td valign=\"middle\" class=\"\">\r\n                                                                            <h1 style=\"color:#676767; font-weight:400; margin:0px\">Today Task Due {%TaskName%}</h1>\r\n                                                                        </td>\r\n                                                                        <td valign=\"middle\" align=\"right\" width=\"200px\" class=\"\">{%emailogo%}</td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td colspan=\"2\" style=\"text-align:center\" class=\"\">\r\n                                                                            <hr width=\"100%\" style=\"background-color:rgb(204,204,204); border:medium none; clear:both; display:block; font-size:0px; min-height:1px; line-height:0; margin:4px 0px 16px 0px\">\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td style=\"min-width:590px\" class=\"\"><br><table class=\"e-rte-table\" style=\"max-width: 1356.5px;\"><tbody><tr><td class=\"\"><div style=\"margin-left:1.2rem; margin-bottom:1em\"><p>Hello {%Name%}</p><p>This is a friendly reminder that the following task is due for completion today:</p><p>Task Name : {%TaskName%}</p><p>Task Id : {%TaskId%}</p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Due Date : {%DueDate%}</span><br></p><p><span style=\"color: rgb(103, 103, 103); font-family: Verdana, Helvetica, Arial, sans-serif, serif, EmojiFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: start; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); display: inline !important; float: none;\">Project Name : {%ProjectName%}</span><br></p><p>Project Id : {%ProjectId%}</p><p>Please ensure that you allocate sufficient time and effort to complete the task within the given deadline. Your prompt attention to this matter will help us maintain project timelines and achieve our goals efficiently.</p></div>\r\n                                                                         \r\n                                                                            <div style=\"margin-left:1.2rem; margin-bottom:1em\">\r\n                                                                                <p style=\"color:#676767; line-height:145%; margin:10px 0 0 0; font-size:16px\">\r\n                                                                                    {%emailsignature%}\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:center; border-top:1px solid rgb(230,230,230); padding-bottom:20px; padding-top:15px; line-height:125%; font-size:11px; margin:20px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); font-size:10px\">© Copyright {%companyname%}, {%address%} </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                    <tr>\r\n                                                                        <td align=\"right\">\r\n                                                                            <div style=\" margin:0 20px\">{%footerletterhera%}</div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                    <tr>\r\n                                                        <td>\r\n                                                            <table style=\"width:100%\" class=\"e-rte-table\">\r\n                                                                <tbody>\r\n                                                                    <tr>\r\n                                                                        <td>\r\n                                                                            <div style=\"text-align:justify; border-top:1px solid rgb(230,230,230); padding-bottom:10px; padding-top:10px; line-height:125%; font-size:10px; margin:25px 20px 0 20px\">\r\n                                                                                <p style=\"color:rgb(115,115,115); margin:0; font-size:10px\">\r\n                                                                                    The information contained in this e-mail message and/or attachments to it may contain confidential\r\n                                                                                    or privileged information. If you are not the intended recipient, any dissemination,use, review, distribution,\r\n                                                                                    printing or copying of the information contained in this email message and/or attachments to it are strictly prohibited.\r\n                                                                                    If you have received this communication in error, please notify us by reply e-mail or telephone and immediately\r\n                                                                                    and permanently delete the message and any attachments. Thank you.\r\n                                                                                </p>\r\n                                                                            </div>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n                                                                </tbody>\r\n                                                            </table>\r\n                                                        </td>\r\n                                                    </tr>\r\n                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div> <div class=\"_rp_c5\" style=\"display: none;\"><br></div>\r\n    </div>  <span class=\"PersonaPaneLauncher\"><div ariatabindex=\"-1\" class=\"_pe_d _pe_62\" aria-expanded=\"false\" tabindex=\"-1\" aria-haspopup=\"false\">  <div style=\"display: none;\"><br></div> </div></span>\r\n</div>", "TaskDueTodayReminder", "Reminder: Today's Task Due - {%Taskname%}", null, null }
                });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 25, 16, 31, 58, 444, DateTimeKind.Local).AddTicks(6820));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "EffortHourRequired",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 22, 11, 37, 13, 157, DateTimeKind.Local).AddTicks(2264));
        }
    }
}
