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
    public interface IRecruitClientContactService
    {

        public MessageEnum RecruitClientContactCreate(RecruitClientContactDTO recruitClientContactDTO);
        public List<RecruitClientContact> GetRecruitClientContactList();
        public RecruitClientContact GetRecruitClientContactId(int RecruitClientContactId);
        public MessageEnum RecruitClientContactUpdate(RecruitClientContactDTO recruitClientContactDTO);
        public MessageEnum RecruitClientContactDelete(int RecruitClientContactId, Int64 DeletedBy);
    }
}
