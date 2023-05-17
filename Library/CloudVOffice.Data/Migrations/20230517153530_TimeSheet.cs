using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class TimeSheet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AssignedBy",
                table: "ProjectTasks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedOn",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelayApprovalReason",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DelayApprovedBy",
                table: "ProjectTasks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DelayApprovedOn",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelayReason",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "ProjectTasks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelayApproved",
                table: "ProjectTasks",
                type: "bit",
                nullable: true);

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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Timesheets",
                columns: table => new
                {
                    TimesheetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    TimeSheetForDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimesheetActivityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
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
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 804, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 17, 21, 5, 29, 805, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducationalQualifications_EmployeeId",
                table: "EmployeeEducationalQualifications",
                column: "EmployeeId");

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
                name: "IX_Timesheets_TimesheetApprovedBy",
                table: "Timesheets",
                column: "TimesheetApprovedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEducationalQualifications");

            migrationBuilder.DropTable(
                name: "Timesheets");

            migrationBuilder.DropColumn(
                name: "AssignedBy",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "AssignedOn",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "DelayApprovalReason",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "DelayApprovedBy",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "DelayApprovedOn",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "DelayReason",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "IsDelayApproved",
                table: "ProjectTasks");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 21, 7, 14, 417, DateTimeKind.Local).AddTicks(8586));
        }
    }
}
