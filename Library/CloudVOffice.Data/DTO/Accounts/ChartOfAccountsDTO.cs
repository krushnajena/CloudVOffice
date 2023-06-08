using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
public class ChartOfAccountsDTO
	{
		public int? ChartOfAccountsId { get; set; }
		public string AccountName { get; set; }
		public string? AccountNumber { get; set; }
		public bool IsGroup { get; set; }
		public string RootType { get; set; } // Asset, Income, Expense , Liab
		public string ReportType { get; set; } // Balance Sheet, PL
		public int? ParentAccountGroupId { get; set; }
		public int? AccountType { get; set; }
		public double? TaxRate { get; set; }
		public string? BalanceMustBe { get; set; }//Cr Dr

		public int CreatedBy { get; set; }
	}
}
