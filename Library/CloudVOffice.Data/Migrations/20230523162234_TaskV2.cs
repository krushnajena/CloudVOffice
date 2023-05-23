using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Employees_ComplitedBy",
                table: "ProjectTasks");

            migrationBuilder.AlterColumn<long>(
                name: "EmployeeId",
                table: "ProjectTasks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ComplitedBy",
                table: "ProjectTasks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskComplitedByOthersReasonByAssign",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaskComplitedByOthersReasonByComplitedBy",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 23, 21, 52, 34, 511, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_EmployeeId",
                table: "ProjectTasks",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Employees_ComplitedBy",
                table: "ProjectTasks",
                column: "ComplitedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Employees_EmployeeId",
                table: "ProjectTasks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Employees_ComplitedBy",
                table: "ProjectTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Employees_EmployeeId",
                table: "ProjectTasks");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTasks_EmployeeId",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "TaskComplitedByOthersReasonByAssign",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "TaskComplitedByOthersReasonByComplitedBy",
                table: "ProjectTasks");

            migrationBuilder.AlterColumn<long>(
                name: "EmployeeId",
                table: "ProjectTasks",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ComplitedBy",
                table: "ProjectTasks",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 904, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 22, 20, 6, 9, 903, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Employees_ComplitedBy",
                table: "ProjectTasks",
                column: "ComplitedBy",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
