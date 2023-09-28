using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JA
{
    public interface IJobApplicationStatusService
    {
        public MessageEnum CreateJobApplicationStatus(JobApplicationStatusDTO jobApplicationStatusDTO);
    }
}
