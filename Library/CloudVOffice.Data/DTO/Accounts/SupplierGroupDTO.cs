using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
	public class SupplierGroupDTO
	{
		public int? SupplierGroupId { get; set; }
		public string SupplierGroupName { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
