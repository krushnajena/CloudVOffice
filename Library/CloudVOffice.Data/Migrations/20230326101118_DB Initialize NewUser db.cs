using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class DBInitializeNewUserdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastLoginDateUtc",
                table: "Users",
                newName: "LastLoginDate");

            migrationBuilder.RenameColumn(
                name: "LastActivityDateUtc",
                table: "Users",
                newName: "LastActivityDate");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 26, 15, 41, 18, 778, DateTimeKind.Local).AddTicks(6194));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastLoginDate",
                table: "Users",
                newName: "LastLoginDateUtc");

            migrationBuilder.RenameColumn(
                name: "LastActivityDate",
                table: "Users",
                newName: "LastActivityDateUtc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 26, 1, 49, 32, 257, DateTimeKind.Local).AddTicks(700));
        }
    }
}
