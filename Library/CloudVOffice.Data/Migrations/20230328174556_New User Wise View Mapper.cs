using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewUserWiseViewMapper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    IconImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Applications_ApplicationId1",
                        column: x => x.ApplicationId1,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "RoleAndApplicationWisePermissions",
                columns: table => new
                {
                    RoleAndApplicationWisePermissionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAndApplicationWisePermissions", x => x.RoleAndApplicationWisePermissionId);
                    table.ForeignKey(
                        name: "FK_RoleAndApplicationWisePermissions_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAndApplicationWisePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWiseViewMappers",
                columns: table => new
                {
                    UserWiseViewMapperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWiseViewMappers", x => x.UserWiseViewMapperId);
                    table.ForeignKey(
                        name: "FK_UserWiseViewMappers_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWiseViewMappers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "ApplicationId1", "ApplicationName", "CreatedBy", "CreatedDate", "Deleted", "IconClass", "IconImageUrl", "IsGroup", "Parent", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1, null, "Applications", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9076), false, null, "/appstatic/images/applications.png", true, null, null, null, "/Applications/InstalledApps" },
                    { 2, null, "Setup", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9080), false, null, "/appstatic/images/setup.png", true, null, null, null, "/Setup/Dashboard" },
                    { 3, null, "Company", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9081), false, null, null, false, 2, null, null, "/Setup/Company" },
                    { 4, null, "User", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9083), false, null, null, true, 2, null, null, "" },
                    { 5, null, "User List", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9084), false, null, null, false, 4, null, null, "/User/UserList" },
                    { 6, null, "Users Activity Log", 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9086), false, null, null, false, null, null, null, "/User/ActivityLog" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.InsertData(
                table: "RoleAndApplicationWisePermissions",
                columns: new[] { "RoleAndApplicationWisePermissionId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "RoleId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9184), false, 1, null, null },
                    { 2L, 2, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9186), false, 1, null, null },
                    { 3L, 3, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9188), false, 1, null, null },
                    { 4L, 4, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9189), false, 1, null, null },
                    { 5L, 5, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9190), false, 1, null, null },
                    { 6L, 6, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9192), false, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserWiseViewMappers",
                columns: new[] { "UserWiseViewMapperId", "ApplicationId", "CreatedBy", "CreatedDate", "Deleted", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1L, 1, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9292), false, null, null, 1L },
                    { 2L, 2, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9296), false, null, null, 1L },
                    { 3L, 3, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9299), false, null, null, 1L },
                    { 4L, 4, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9301), false, null, null, 1L },
                    { 5L, 5, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9304), false, null, null, 1L },
                    { 6L, 6, 1, new DateTime(2023, 3, 28, 23, 15, 56, 671, DateTimeKind.Local).AddTicks(9306), false, null, null, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationId1",
                table: "Applications",
                column: "ApplicationId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAndApplicationWisePermissions_ApplicationId",
                table: "RoleAndApplicationWisePermissions",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAndApplicationWisePermissions_RoleId",
                table: "RoleAndApplicationWisePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWiseViewMappers_ApplicationId",
                table: "UserWiseViewMappers",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWiseViewMappers_UserId",
                table: "UserWiseViewMappers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleAndApplicationWisePermissions");

            migrationBuilder.DropTable(
                name: "UserWiseViewMappers");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 15, 2, 20, 457, DateTimeKind.Local).AddTicks(9615));
        }
    }
}
