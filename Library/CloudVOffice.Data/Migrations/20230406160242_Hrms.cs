using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class Hrms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaName",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Departments_DepartmentId1",
                        column: x => x.DepartmentId1,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    EmploymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.EmploymentTypeId);
                });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Application", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Setup", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Setup", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Setup", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Setup", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "AreaName", "CreatedDate" },
                values: new object[] { "Setup", new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 21, 32, 41, 804, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentId1",
                table: "Departments",
                column: "DepartmentId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "AreaName",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(8700));
        }
    }
}
