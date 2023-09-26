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
            var a = _Context.JobOpeningSkills.Where(x => x.SkillId == SkillId && x.JobId == JobId && x.Deleted == false).ToList();
            if (a.Count ==0) {
                JobOpeningSkill skill = new JobOpeningSkill();
                skill.JobId = JobId;
                skill.SkillId = SkillId;
                skill.CreatedBy = createdBy;
                skill.CreatedDate = DateTime.Now;
                _jobOpeningRepo.Insert(skill);
            }
            
            return MessageEnum.Success;

        }

        public List<JobOpeningSkill> RemoveUnListedSkills(List<int> skills,int jobId,Int64 updatedBy)
        {
            var a = _Context.JobOpeningSkills.Where(x => x.Deleted == false && !skills.Contains(x.SkillId) && x.JobId == jobId).ToList();
            for(int i = 0; i < a.Count; i++)
            {
                var skill = a[i];
                skill.Deleted = true;
                skill.UpdatedDate= DateTime.Now;
                skill.UpdatedBy = updatedBy;
                _Context.SaveChanges();
            }
            return a;
        }
    }
}
