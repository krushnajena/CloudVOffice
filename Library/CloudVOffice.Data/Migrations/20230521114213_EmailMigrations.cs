using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmailMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultSendingAccount",
                table: "EmailTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 447, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 17, 12, 13, 450, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.CreateIndex(
                name: "IX_EmailAccounts_Domain",
                table: "EmailAccounts",
                column: "Domain");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAccounts_EmailDomains_Domain",
                table: "EmailAccounts",
                column: "Domain",
                principalTable: "EmailDomains",
                principalColumn: "EmailDomainId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAccounts_EmailDomains_Domain",
                table: "EmailAccounts");

            migrationBuilder.DropIndex(
                name: "IX_EmailAccounts_Domain",
                table: "EmailAccounts");

            migrationBuilder.DropColumn(
                name: "DefaultSendingAccount",
                table: "EmailTemplates");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "EmailTemplates");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 294, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 295, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 21, 12, 23, 51, 294, DateTimeKind.Local).AddTicks(9754));
        }
    }
}
