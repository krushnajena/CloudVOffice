using CloudVOffice.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JO
{
    public interface IJobOpeningSkillService
    {
        public MessageEnum CreateJobOpeningSkill(int JobId, int SkillId, Int64 createdBy);
    }
}
