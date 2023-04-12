using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Comunication
{
    public class EmailAccounts : IAuditEntity, ISoftDeletedEntity
    {
        public string EmailAddress { get; set; }
        public int Domain { get; set; }
        public string EmailAccountName { get; set; }
        public string EmailPassword { get; set; }
        public string AlternativeEmailAddress { get; set; }

        public string EmailSignature { get; set; }
        public string EmailLogo { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
