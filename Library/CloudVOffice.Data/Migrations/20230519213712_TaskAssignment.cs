using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignments_Employees_AssignedBy",
                table: "TaskAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignments_Employees_CompliteBy",
                table: "TaskAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignments_Employees_DelayApprovedBy",
                table: "TaskAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignments_Employees_EmployeeId",
                table: "TaskAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignments_ProjectTasks_TaskId",
                table: "TaskAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskAssignments",
                table: "TaskAssignments");

            migrationBuilder.RenameTable(
                name: "TaskAssignments",
                newName: "TaskAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignments_TaskId",
                table: "TaskAssignment",
                newName: "IX_TaskAssignment_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignments_EmployeeId",
                table: "TaskAssignment",
                newName: "IX_TaskAssignment_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignments_DelayApprovedBy",
                table: "TaskAssignment",
                newName: "IX_TaskAssignment_DelayApprovedBy");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignments_CompliteBy",
                table: "TaskAssignment",
                newName: "IX_TaskAssignment_CompliteBy");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignments_AssignedBy",
                table: "TaskAssignment",
                newName: "IX_TaskAssignment_AssignedBy");

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskAssignment",
                table: "TaskAssignment",
                column: "TaskAssignmentId");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 3, 7, 11, 825, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignment_Employees_AssignedBy",
                table: "TaskAssignment",
                column: "AssignedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignment_Employees_CompliteBy",
                table: "TaskAssignment",
                column: "CompliteBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignment_Employees_DelayApprovedBy",
                table: "TaskAssignment",
                column: "DelayApprovedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignment_Employees_EmployeeId",
                table: "TaskAssignment",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignment_ProjectTasks_TaskId",
                table: "TaskAssignment",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "ProjectTaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignment_Employees_AssignedBy",
                table: "TaskAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignment_Employees_CompliteBy",
                table: "TaskAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignment_Employees_DelayApprovedBy",
                table: "TaskAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignment_Employees_EmployeeId",
                table: "TaskAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignment_ProjectTasks_TaskId",
                table: "TaskAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskAssignment",
                table: "TaskAssignment");

            migrationBuilder.RenameTable(
                name: "TaskAssignment",
                newName: "TaskAssignments");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignment_TaskId",
                table: "TaskAssignments",
                newName: "IX_TaskAssignments_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignment_EmployeeId",
                table: "TaskAssignments",
                newName: "IX_TaskAssignments_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignment_DelayApprovedBy",
                table: "TaskAssignments",
                newName: "IX_TaskAssignments_DelayApprovedBy");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignment_CompliteBy",
                table: "TaskAssignments",
                newName: "IX_TaskAssignments_CompliteBy");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignment_AssignedBy",
                table: "TaskAssignments",
                newName: "IX_TaskAssignments_AssignedBy");

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskAssignments",
                table: "TaskAssignments",
                column: "TaskAssignmentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignments_Employees_AssignedBy",
                table: "TaskAssignments",
                column: "AssignedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignments_Employees_CompliteBy",
                table: "TaskAssignments",
                column: "CompliteBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignments_Employees_DelayApprovedBy",
                table: "TaskAssignments",
                column: "DelayApprovedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignments_Employees_EmployeeId",
                table: "TaskAssignments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignments_ProjectTasks_TaskId",
                table: "TaskAssignments",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "ProjectTaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
