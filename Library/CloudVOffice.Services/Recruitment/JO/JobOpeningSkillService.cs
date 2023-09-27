using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JO
{
    public class JobOpeningSkillService : IJobOpeningSkillService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobOpeningSkill> _jobOpeningRepo;
        public JobOpeningSkillService(ApplicationDBContext Context, ISqlRepository<JobOpeningSkill> jobOpeningRepo)
        {

            _Context = Context;
            _jobOpeningRepo = jobOpeningRepo;
        }
        public MessageEnum CreateJobOpeningSkill(int JobId, int SkillId, Int64 createdBy)
        {
            JobOpeningSkill skill =  new JobOpeningSkill();
            skill.JobId = JobId;
            skill.SkillId = SkillId;
            skill.CreatedBy = createdBy;
            skill.CreatedDate = DateTime.Now;
            _jobOpeningRepo.Insert(skill);  
            return MessageEnum.Success;

        }
    }
}
