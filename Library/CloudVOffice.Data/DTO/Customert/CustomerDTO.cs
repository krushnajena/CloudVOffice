using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Customert
{
    public class CustomerDTO
    {
        public Int64? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerGroupId { get; set; }
        public string TaxId { get; set; }
        public Int64? AccountManagerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmailId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
