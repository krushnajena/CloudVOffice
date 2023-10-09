using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
    public class SupplierDTO
    {
        public Int64? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int SupplierGroupId { get; set; }
        public string SupplierType { get; set; }
        public bool IsTransporter { get; set; }
        public int? DefaultCompanyBankAccount { get; set; }
        public bool IsInternalSupplier { get; set; }
        public string? RepresentsCompany { get; set; }
        public string TaxID { get; set; }
        public string SupplierPrimaryContact { get; set; }
        public string SupplierPrimaryAddress { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
