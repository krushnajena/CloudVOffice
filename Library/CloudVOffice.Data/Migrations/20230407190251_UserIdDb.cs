using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserIdDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "UserWiseViewMappers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "UserWiseViewMappers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Roles",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Roles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "RoleAndApplicationWisePermissions",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "RoleAndApplicationWisePermissions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Logs",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "EmploymentTypes",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "EmploymentTypes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Designations",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Designations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Departments",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Departments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Branches",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Branches",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UpdatedBy",
                table: "Applications",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "Applications",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "ActivityLogs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3543), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3547), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3549), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3551), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3554), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3556), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3651), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3653), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3654), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3655), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3656), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3657), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(2112), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3750), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3752), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3754), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3755), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3756), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3757), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1L, new DateTime(2023, 4, 8, 0, 32, 51, 541, DateTimeKind.Local).AddTicks(3206), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "UserWiseViewMappers",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "UserWiseViewMappers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Roles",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "RoleAndApplicationWisePermissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "RoleAndApplicationWisePermissions",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Logs",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "EmploymentTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "EmploymentTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Designations",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Designations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Branches",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Branches",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Applications",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ActivityLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3621), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3625), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3627), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3628), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3630), null });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3632), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3731), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3734), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3739), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3740), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3741), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3773), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(2083), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3877), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3881), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3882), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3884), null });

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3885), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedDate", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 21, 5, 8, 722, DateTimeKind.Local).AddTicks(3305), null });
        }
    }
}
