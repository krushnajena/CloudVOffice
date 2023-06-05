using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CloudVOffice.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChartOfAccountsmIGRATIONS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccountType",
                table: "ChartOfAccounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "ChartOfAccounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "AccountTypeId", "AccountTypeName", "CreatedBy", "CreatedDate", "Deleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Accumulated Depreciation", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7083), false, null, null },
                    { 2, "Asset Received But Not Billed", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7084), false, null, null },
                    { 3, "Bank", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7086), false, null, null },
                    { 4, "Cash", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7087), false, null, null },
                    { 5, "Chargeable", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7088), false, null, null },
                    { 6, "Capital Work in Progress", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7089), false, null, null },
                    { 7, "Cost of Goods Sold", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7090), false, null, null },
                    { 8, "Depreciation", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7091), false, null, null },
                    { 9, "Equity", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7092), false, null, null },
                    { 10, "Expense Account", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7093), false, null, null },
                    { 11, "Expenses Included In Asset Valuation", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7094), false, null, null },
                    { 12, "Expenses Included In Valuation", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7095), false, null, null },
                    { 13, "Fixed Asset", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7096), false, null, null },
                    { 14, "Income Account", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7097), false, null, null },
                    { 15, "Payable", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7098), false, null, null },
                    { 16, "Receivable", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7099), false, null, null },
                    { 17, "Round Off", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7100), false, null, null },
                    { 18, "Stock", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7101), false, null, null },
                    { 19, "Stock Adjustment", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7102), false, null, null },
                    { 20, "Stock Received But Not Billed", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7103), false, null, null },
                    { 21, "Service Received But Not Billed", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7104), false, null, null },
                    { 22, "Tax", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7105), false, null, null },
                    { 23, "Temporary", 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7106), false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.InsertData(
                table: "ChartOfAccounts",
                columns: new[] { "ChartOfAccountsId", "AccountName", "AccountNumber", "AccountType", "BalanceMustBe", "ChartOfAccountsId1", "CreatedBy", "CreatedDate", "Deleted", "IsGroup", "ParentAccountGroupId", "ReportType", "RootType", "TaxRate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Application of Funds (Assets)", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7258), false, true, null, "Balance Sheet", "Assets", null, null, null },
                    { 2, "Current Assets", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7262), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 3, "Accounts Receivable", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7264), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 4, "Debtors", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7266), false, false, 3, "Balance Sheet", "Assets", null, null, null },
                    { 5, "Bank Accounts", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7268), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 6, "Cash In Hand", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7269), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 7, "Cash", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7342), false, false, 6, "Balance Sheet", "Assets", null, null, null },
                    { 8, "Loans and Advances (Assets)", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7344), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 9, "Securities and Deposits", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7346), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 10, "Earnest Money", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7348), false, false, 9, "Balance Sheet", "Assets", null, null, null },
                    { 11, "Stock Assets", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7351), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 12, "Stock In Hand", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7353), false, false, 11, "Balance Sheet", "Assets", null, null, null },
                    { 13, "Tax Assets", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7354), false, true, 2, "Balance Sheet", "Assets", null, null, null },
                    { 14, "Fixed Assets", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7356), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 15, "Accumulated Depreciations", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7358), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 16, "Accumulated Depreciations", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7360), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 17, "Buildings", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7362), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 18, "Capital Equipments", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7363), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 19, "Electronic Equipments", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7365), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 20, "Furnitures and Fixtures", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7368), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 21, "Office Equipments", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7370), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 22, "Plants and Machineries", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7372), false, false, 14, "Balance Sheet", "Assets", null, null, null },
                    { 23, "Investments", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7373), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 24, "Temporary Accounts", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7375), false, true, 1, "Balance Sheet", "Assets", null, null, null },
                    { 25, "Temporary Opening", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7377), false, false, 24, "Balance Sheet", "Assets", null, null, null },
                    { 26, "Source of Funds (Liabilities)", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7379), false, true, null, "Balance Sheet", "Liability", null, null, null },
                    { 27, "Capital Account", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7381), false, true, 26, "Balance Sheet", "Liability", null, null, null },
                    { 28, "Reserves and Surplus", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7382), false, false, 27, "Balance Sheet", "Liability", null, null, null },
                    { 29, "Shareholders Funds", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7385), false, false, 27, "Balance Sheet", "Liability", null, null, null },
                    { 30, "Current Liabilities", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7387), false, true, 26, "Balance Sheet", "Liability", null, null, null },
                    { 31, "Accounts Payable", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7389), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 32, "Creditors", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7390), false, false, 31, "Balance Sheet", "Liability", null, null, null },
                    { 33, "Payroll Payable", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7392), false, false, 31, "Balance Sheet", "Liability", null, null, null },
                    { 34, "Duties and Taxes", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7394), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 35, "TDS", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7396), false, false, 34, "Balance Sheet", "Liability", null, null, null },
                    { 36, "Loans (Liabilities)", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7400), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 37, "Bank Overdraft Account", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7402), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 38, "Secured Loans", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7404), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 39, "Unsecured Loans", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7406), false, false, 36, "Balance Sheet", "Liability", null, null, null },
                    { 40, "Stock Liabilities", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7408), false, true, 30, "Balance Sheet", "Liability", null, null, null },
                    { 41, "Stock Received But Not Billed", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7412), false, false, 40, "Balance Sheet", "Liability", null, null, null },
                    { 42, "Income", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7414), false, true, null, "Profit and Loss", "Income", null, null, null },
                    { 43, "Direct Income", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7416), false, true, 42, "Profit and Loss", "Income", null, null, null },
                    { 44, "Sales", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7417), false, false, 43, "Profit and Loss", "Income", null, null, null },
                    { 45, "Service", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7419), false, false, 43, "Profit and Loss", "Income", null, null, null },
                    { 46, "Indirect Income", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7421), false, true, 42, "Profit and Loss", "Income", null, null, null },
                    { 47, "Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7424), false, true, null, "Profit and Loss", "Expense", null, null, null },
                    { 48, "Direct Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7425), false, true, 47, "Profit and Loss", "Expense", null, null, null },
                    { 49, "Stock Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7427), false, true, 48, "Profit and Loss", "Expense", null, null, null },
                    { 50, "Cost of Goods Sold", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7429), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 51, "Expenses Included In Valuation", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7431), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 52, "Stock Adjustment", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7432), false, false, 49, "Profit and Loss", "Expense", null, null, null },
                    { 53, "Indirect Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7434), false, true, 47, "Profit and Loss", "Expense", null, null, null },
                    { 54, "Administrative Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7436), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 55, "Commission on Sales", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7438), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 56, "Depreciation", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7440), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 57, "Entertainment Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7442), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 58, "Exchange Gain/Loss", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7444), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 59, "Freight and Forwarding Charges", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7446), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 60, "Gain/Loss on Asset Disposal", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7450), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 61, "Legal Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7531), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 62, "Marketing Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7533), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 63, "Miscellaneous Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7535), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 64, "Office Maintenance Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7539), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 65, "Office Rent", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7541), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 66, "Postal Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7543), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 67, "Print and Stationary", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7544), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 68, "Rounded Off", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7546), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 69, "Salary", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7548), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 70, "Sales Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7550), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 71, "Telephone Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7552), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 72, "Travel Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7553), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 73, "Utility Expenses", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7555), false, false, 53, "Profit and Loss", "Expense", null, null, null },
                    { 74, "Write Off", null, null, null, null, 1L, new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(7557), false, false, 53, "Profit and Loss", "Expense", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 6, 1, 23, 8, 591, DateTimeKind.Local).AddTicks(4607));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ChartOfAccounts",
                keyColumn: "ChartOfAccountsId",
                keyValue: 74);

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "ChartOfAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "ChartOfAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "RoleAndApplicationWisePermissions",
                keyColumn: "RoleAndApplicationWisePermissionId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "UserWiseViewMappers",
                keyColumn: "UserWiseViewMapperId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 5, 11, 27, 47, 427, DateTimeKind.Local).AddTicks(1827));
        }
    }
}
