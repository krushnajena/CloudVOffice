using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class JobOpTagsMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffingPlanId",
                table: "StaffingPlanDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobOpeningSkills",
                columns: table => new
                {
                    JobOpeningSkillId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpeningSkills", x => x.JobOpeningSkillId);
                    table.ForeignKey(
                        name: "FK_JobOpeningSkills_JobOpenings_JobId",
                        column: x => x.JobId,
                        principalTable: "JobOpenings",
                        principalColumn: "JobOpeningId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOpeningSkills_SkillSets_SkillId",
                        column: x => x.SkillId,
                        principalTable: "SkillSets",
                        principalColumn: "SkillSetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobOpeningTags",
                columns: table => new
                {
                    JobOpeningTagId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpeningTags", x => x.JobOpeningTagId);
                    table.ForeignKey(
                        name: "FK_JobOpeningTags_Employees_TagId",
                        column: x => x.TagId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobOpeningTags_JobOpenings_JobId",
                        column: x => x.JobId,
                        principalTable: "JobOpenings",
                        principalColumn: "JobOpeningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "AccountTypes",
                keyColumn: "AccountTypeId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 798, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "TimesheetActivityCategories",
                keyColumn: "TimesheetActivityCategoryId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 24, 23, 31, 18, 799, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.CreateIndex(
                name: "IX_StaffingPlanDetails_StaffingPlanId",
                table: "StaffingPlanDetails",
                column: "StaffingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_ClientID",
                table: "JobOpenings",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpeningSkills_JobId",
                table: "JobOpeningSkills",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpeningSkills_SkillId",
                table: "JobOpeningSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpeningTags_JobId",
                table: "JobOpeningTags",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpeningTags_TagId",
                table: "JobOpeningTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_RecruitClients_ClientID",
                table: "JobOpenings",
                column: "ClientID",
                principalTable: "RecruitClients",
                principalColumn: "RecruitClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffingPlanDetails_StaffingPlans_StaffingPlanId",
                table: "StaffingPlanDetails",
                column: "StaffingPlanId",
                principalTable: "StaffingPlans",
                principalColumn: "StaffingPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_RecruitClients_ClientID",
                table: "JobOpenings");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffingPlanDetails_StaffingPlans_StaffingPlanId",
                table: "StaffingPlanDetails");

            migrationBuilder.DropTable(
                name: "JobOpeningSkills");

            migrationBuilder.DropTable(
                name: "JobOpeningTags");

            migrationBuilder.DropIndex(
                name: "IX_StaffingPlanDetails_StaffingPlanId",
                table: "StaffingPlanDetails");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_ClientID",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "StaffingPlanId",
                table: "StaffingPlanDetails");

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
        }
    }
}
