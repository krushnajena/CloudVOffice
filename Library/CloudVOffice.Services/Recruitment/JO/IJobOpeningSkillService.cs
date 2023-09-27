using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
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

        public List<JobOpeningSkill> RemoveUnListedSkills(List<int> skills, int jobId,Int64 updatedBy);
    }
}
