using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JA
{
    public interface IJobApplicationService
    {
        public MessageEnum JobApplicationCreate(JobApplicationDTO jobApplicationDTO);
        public List<JobApplication> GetJobApplicationList();
        public JobApplication GetJobApplicationById(Int64 jobApplicationId);
        public MessageEnum SubmitForScreeningStatus(JobApplicationDTO jobApplicationDTO);
        public MessageEnum JobApplicationDelete(Int64 jobApplicationId, Int64 DeletedBy);
        public List<JobApplication> JobApplicationsNotSentForScreening(int JobId);
    }
}
