using CloudVOffice.Core.Domain.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Accounts
{
    public class Supplier
    {
        public Int64 SupplierId { get; set; }
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
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("SupplierGroupId")]
        public SupplierGroup supplierGroup { get; set; }

    }
}
