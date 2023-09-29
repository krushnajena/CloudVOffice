using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JA
{
    public class JobApplicatonStatusService : IJobApplicationStatusService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobApplicationStatus> _jobApplication;

        public JobApplicatonStatusService(ApplicationDBContext Context, ISqlRepository<JobApplicationStatus> jobApplication)
        {
            _Context = Context;
            _jobApplication = jobApplication;
        }
        public MessageEnum CreateJobApplicationStatus(JobApplicationStatusDTO jobApplicationStatusDTO)
        {
            _jobApplication.Insert(new JobApplicationStatus
            {
                JobApplicationId = jobApplicationStatusDTO.JobApplicationId,
                Status = jobApplicationStatusDTO.Status,
                StatusUpBy = jobApplicationStatusDTO.StatusUpBy,
                Comment = jobApplicationStatusDTO.Comment,
                ClientContactId = jobApplicationStatusDTO.ClientContactId,
                EmployeeId = jobApplicationStatusDTO.EmployeeId,
                CreatedBy = jobApplicationStatusDTO.CreatedBy,
                CreatedDate = DateTime.Now
            });
            return MessageEnum.Success;
        }
    }
}
