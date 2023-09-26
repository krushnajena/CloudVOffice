using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class CandNewMigv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 26, 19, 30, 47, 15, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.CreateIndex(
                name: "IX_LeavePolicyDetails_LeaveTypeId",
                table: "LeavePolicyDetails",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicyDetails_LeaveTypes_LeaveTypeId",
                table: "LeavePolicyDetails",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "LeaveTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicyDetails_LeaveTypes_LeaveTypeId",
                table: "LeavePolicyDetails");

            migrationBuilder.DropIndex(
                name: "IX_LeavePolicyDetails_LeaveTypeId",
                table: "LeavePolicyDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Candidates");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 924, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 25, 0, 57, 27, 925, DateTimeKind.Local).AddTicks(562));
        }
    }
}
