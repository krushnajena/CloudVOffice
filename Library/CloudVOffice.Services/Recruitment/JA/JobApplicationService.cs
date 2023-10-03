using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment.JA
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobApplication> _jobApplication;
        private readonly IJobApplicationStatusService _jobApplicationStatusService;
        public JobApplicationService(ApplicationDBContext Context, ISqlRepository<JobApplication> jobApplication, IJobApplicationStatusService jobApplicationStatusService)
        {
            _Context = Context;
            _jobApplication = jobApplication;
            _jobApplicationStatusService = jobApplicationStatusService;
        }
        public MessageEnum JobApplicationCreate(JobApplicationDTO jobApplicationDTO)
        {
            var objCheck = _Context.JobApplications.SingleOrDefault(x => x.JobId == jobApplicationDTO.JobId && x.CandidateId == jobApplicationDTO.CandidateId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    JobApplication jobApplication = new JobApplication();
                    jobApplication.JobId = jobApplicationDTO.JobId;
                    jobApplication.CandidateId = jobApplicationDTO.CandidateId;
                    jobApplication.TagId = jobApplicationDTO.TagId;
                    jobApplication.Created = DateTime.Now;
                    jobApplication.CurrentStatus = jobApplicationDTO.CurrentStatus;
                    jobApplication.ApplicationViewToken = jobApplicationDTO.ApplicationViewToken;
                    jobApplication.CreatedBy = jobApplicationDTO.CreatedBy;
                    var obj = _jobApplication.Insert(jobApplication);
                    _jobApplicationStatusService.CreateJobApplicationStatus(new JobApplicationStatusDTO
                    {
                        JobApplicationId = obj.JobApplicationId,
                        Status = 1,
                        StatusUpBy = 1,
                        Comment = jobApplicationDTO.Comment,
                        EmployeeId = jobApplicationDTO.TagId,
                        CreatedBy = jobApplicationDTO.CreatedBy
                    }) ;
                    return MessageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MessageEnum.Duplicate;
                }
                return MessageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public JobApplication GetJobApplicationById(long jobApplicationId)
        {
            try
            {
                return _Context.JobApplications
                        
                    .SingleOrDefault(x => x.JobApplicationId == jobApplicationId && x.Deleted == false);
            }
            catch
            {
                throw;
            }
        }

        public List<JobApplication> GetJobApplicationList()
        {
            try
            {
                return _Context.JobApplications.Where(x => x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }



        public MessageEnum JobApplicationDelete(long jobApplicationId, long DeletedBy)
        {
            try
            {
                var a = _Context.JobApplications.Where(x => x.JobApplicationId == jobApplicationId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum JobApplicationUpdate(JobApplicationDTO jobApplicationDTO)
        {
            try
            {
                var jobApplication = _Context.JobApplications.Where(x => x.JobApplicationId != jobApplicationDTO.JobApplicationId && x.JobId == jobApplicationDTO.JobId && x.Deleted == false).FirstOrDefault();
                if (jobApplication == null)
                {
                    var a = _Context.JobApplications.Where(x => x.JobApplicationId == jobApplicationDTO.JobApplicationId).FirstOrDefault();
                    if (a != null)
                    {
                        a.JobId = jobApplicationDTO.JobId;
                        a.CandidateId = jobApplicationDTO.CandidateId;
                        a.CandidateId = jobApplicationDTO.CandidateId;
                        a.UpdatedBy = jobApplicationDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;

                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }

        public List<JobApplication> GetCandidateByJobApplication(int JobId)
        {
            try
            {
                 return _Context.JobApplications
                .Include(x => x.Candidate)
                .Where(x => x.JobId == JobId && x.CurrentStatus == 1 && !x.Deleted)
                .ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
