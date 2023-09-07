
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public interface IRecruitClientDocumentService
    {
        public MessageEnum RecruitClientDocumentCreate(RecruitClientDocumentDTO recruitClientDocumentDTO);
        public List<RecruitClientDocument> GetRecruitClientDocumentList();
        public RecruitClientDocument GetRecruitClientDocumentById(Int64 recruitClientDocumentId);
        public MessageEnum RecruitClientDocumentUpdate(RecruitClientDocumentDTO recruitClientDocumentDTO);
        public MessageEnum RecruitClientDocumentDelete(Int64 recruitClientDocumentId, Int64 DeletedBy);
    }
}
