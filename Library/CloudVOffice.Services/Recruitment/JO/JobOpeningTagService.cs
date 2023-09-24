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
            JobOpeningTag tag = new JobOpeningTag();
            tag.JobId = JobId;
            tag.TagId = EmployeeId;
            tag.CreatedBy = createdBy;
            tag.CreatedDate = DateTime.Now;
            _jobOpeningRepo.Insert(tag);
            return MessageEnum.Success;

        }
    }
}
