using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JO
{
    public interface IJobOpeningTagService
    {
        public MessageEnum CreateJobOpeningTag(int JobId, Int64 EmployeeId, Int64 createdBy);
        public List<JobOpeningTag> RemoveUnListedTags(List<Int64> Tags, int jobId, Int64 updatedBy);
    }
}
