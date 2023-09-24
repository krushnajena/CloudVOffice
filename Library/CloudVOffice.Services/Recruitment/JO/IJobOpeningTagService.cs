using CloudVOffice.Core.Domain.Common;
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
    }
}
