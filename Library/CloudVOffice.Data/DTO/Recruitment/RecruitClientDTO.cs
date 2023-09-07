using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class RecruitClientDTO
    {
        public int? RecruitClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactNo { get; set; }
        public Int64 AccountManagerId { get; set; }

        public string Website { get; set; }
        public string Fax { get; set; }
        public string About { get; set; }

        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }


        public Int64 CreatedBy { get; set; }
    }
}
