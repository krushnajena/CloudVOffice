using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class RecruitClient : IAuditEntity, ISoftDeletedEntity
    {
        public int RecruitClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactNo { get; set; }
        public Int64 AccountManagerId { get; set; } //Employee

        public string Website { get; set; }
        public string Fax { get; set; }
        public string About { get; set; }

        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set;}
        public string BillingState { get; set;}
        public string BillingCountry { get; set;}   
        public string BillingPostalCode { get;set;}


        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }


        [ForeignKey("AccountManagerId")]
        public Employee Employee{ get; set; }

		public ICollection<RecruitClientDocument> RecruitClientDocuments { get; set; }

	}
}
