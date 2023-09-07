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
    public interface IRecruitClientService
    {
        public MessageEnum RecruitClientCreate(RecruitClientDTO recruitClientDTO);
        public List<RecruitClient> GetRecruitClientList();
        public RecruitClient GetRecruitClientById(int recruitClientId);
        public MessageEnum RecruitClientUpdate(RecruitClientDTO recruitClientDTO);
        public MessageEnum RecruitClientDelete(int recruitClientId, Int64 DeletedBy);
    }
}
