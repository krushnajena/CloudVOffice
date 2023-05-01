using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class DesktopLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComputerName",
                table: "DesktopLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "IdelTime",
                table: "DesktopLogins",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpAddress",
                table: "DesktopLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Parent" },
                values: new object[] { new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5356), 2 });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 1, 21, 9, 20, 320, DateTimeKind.Local).AddTicks(4784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerName",
                table: "DesktopLogins");

            migrationBuilder.DropColumn(
                name: "IdelTime",
                table: "DesktopLogins");

            migrationBuilder.DropColumn(
                name: "IpAddress",
                table: "DesktopLogins");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Parent" },
                values: new object[] { new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5561), null });

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 10, 27, 18, 858, DateTimeKind.Local).AddTicks(5207));
        }
    }
}
