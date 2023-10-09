using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
    public class BankDTO
    {
        public Int64? BankId { get; set; }
        public string BankName { get; set; }
        public string? SwiftNo { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
