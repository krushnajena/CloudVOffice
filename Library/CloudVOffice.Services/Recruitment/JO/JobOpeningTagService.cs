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
    public class JobOpeningTagService : IJobOpeningTagService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobOpeningTag> _jobOpeningRepo;
        public JobOpeningTagService(ApplicationDBContext Context, ISqlRepository<JobOpeningTag> jobOpeningRepo)
        {

            _Context = Context;
            _jobOpeningRepo = jobOpeningRepo;
        }
        public MessageEnum CreateJobOpeningTag(int JobId, Int64 EmployeeId, Int64 createdBy)
        {
            var a = _Context.JobOpeningTags.Where(x => x.TagId == EmployeeId && x.JobId == JobId && x.Deleted == false).ToList();
            if (a.Count == 0)
            {
                JobOpeningTag tag = new JobOpeningTag();
                tag.JobId = JobId;
                tag.TagId = EmployeeId;
                tag.CreatedBy = createdBy;
                tag.CreatedDate = DateTime.Now;
                _jobOpeningRepo.Insert(tag);
              
            }
            return MessageEnum.Success;

        }

        public List<JobOpeningTag> RemoveUnListedTags(List<Int64> Tags, int jobId, Int64 updatedBy)
        {
            var a = _Context.JobOpeningTags.Where(x => x.Deleted == false && !Tags.Contains(x.TagId) && x.JobId == jobId).ToList();
            for (int i = 0; i < a.Count; i++)
            {
                var skill = a[i];
                skill.Deleted = true;
                skill.UpdatedDate = DateTime.Now;
                skill.UpdatedBy = updatedBy;
                _Context.SaveChanges();
            }
            return a;
        }
    }
}
