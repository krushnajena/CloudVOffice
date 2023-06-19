using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffingPlanDetails_Designations_DesgnationId",
                table: "StaffingPlanDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets");

            migrationBuilder.RenameColumn(
                name: "DesgnationId",
                table: "StaffingPlanDetails",
                newName: "DesignationId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffingPlanDetails_DesgnationId",
                table: "StaffingPlanDetails",
                newName: "IX_StaffingPlanDetails_DesignationId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Timesheets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 77, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 89, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 17, 16, 32, 45, 88, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_TimesheetActivityType",
                table: "Timesheets",
                column: "TimesheetActivityType");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffingPlanDetails_Designations_DesignationId",
                table: "StaffingPlanDetails",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_TimesheetActivityCategories_TimesheetActivityType",
                table: "Timesheets",
                column: "TimesheetActivityType",
                principalTable: "TimesheetActivityCategories",
                principalColumn: "TimesheetActivityCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffingPlanDetails_Designations_DesignationId",
                table: "StaffingPlanDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_TimesheetActivityCategories_TimesheetActivityType",
                table: "Timesheets");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_Timesheets_TimesheetActivityType",
                table: "Timesheets");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "StaffingPlanDetails",
                newName: "DesgnationId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffingPlanDetails_DesignationId",
                table: "StaffingPlanDetails",
                newName: "IX_StaffingPlanDetails_DesgnationId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Timesheets",
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
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 990, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 991, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 10, 12, 18, 49, 990, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.AddForeignKey(
                name: "FK_StaffingPlanDetails_Designations_DesgnationId",
                table: "StaffingPlanDetails",
                column: "DesgnationId",
                principalTable: "Designations",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
