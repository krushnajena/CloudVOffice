using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class RecruitClientDocumentDTO
    {
        public Int64? RecruitClientDocumentId { get; set; }
        public int RecruitClientId { get; set; }
        public string DocumentType { get; set; }
        public string Document { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
