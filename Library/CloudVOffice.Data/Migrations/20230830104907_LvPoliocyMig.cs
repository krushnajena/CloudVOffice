using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class LvPoliocyMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeavePolicies",
                columns: table => new
                {
                    LeavePolicyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeavePeriod = table.Column<int>(type: "int", nullable: false),
                    EmployeeGradeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavePolicies", x => x.LeavePolicyId);
                });

            migrationBuilder.CreateTable(
                name: "LeavePolicyDetails",
                columns: table => new
                {
                    LeavePolicyDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeavePolicyId = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    NoOfLeaves = table.Column<int>(type: "int", nullable: false),
                    AllocationMode = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavePolicyDetails", x => x.LeavePolicyDetailsId);
                });

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 893, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 16, 19, 6, 892, DateTimeKind.Local).AddTicks(8110));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeavePolicies");

            migrationBuilder.DropTable(
                name: "LeavePolicyDetails");

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 414, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 15, 45, 58, 413, DateTimeKind.Local).AddTicks(6797));
        }
    }
}
