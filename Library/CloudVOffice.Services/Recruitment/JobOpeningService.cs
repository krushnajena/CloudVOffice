using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Recruitment
{
    public class JobOpeningService : IJobOpeningService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobOpening> _jobOpeningRepo;
        public JobOpeningService(ApplicationDBContext Context, ISqlRepository<JobOpening> jobOpeningRepo)
        {

            _Context = Context;
            _jobOpeningRepo = jobOpeningRepo;
        }
        public MessageEnum JobOpeningCreate(JobOpeningDTO jobOpeningDTO)
        {
            var objCheck = _Context.JobOpenings.SingleOrDefault(x => x.JobOpeningId== jobOpeningDTO.JobOpeningId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    JobOpening jobOpening = new JobOpening();
                    jobOpening.JobTitle = jobOpeningDTO.JobTitle;
                    jobOpening.DepartmentId = jobOpeningDTO.DepartmentId;
                    jobOpening.DesignationId = jobOpeningDTO.DesignationId;
					jobOpening.SkillSetId = jobOpeningDTO.SkillSetId;
					jobOpening.Status = jobOpeningDTO.Status;
                    jobOpening.Description = jobOpeningDTO.Description;
                    jobOpening.SalaryLowerRange = jobOpeningDTO.SalaryLowerRange;
                    jobOpening.SalaryUpperRange = jobOpeningDTO.SalaryUpperRange;
                    jobOpening.CreatedBy = jobOpeningDTO.CreatedBy;
                    var obj = _jobOpeningRepo.Insert(jobOpening);
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
        public JobOpening GetJobOpeningByJobOpeningId(int jobOpeningId)
        {
            try
            {
                return _Context.JobOpenings.Where(x => x.JobOpeningId == jobOpeningId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;

            }
        }

        public List<JobOpening> GetJobOpeningsList()
        {

            try
            {
                return _Context.JobOpenings.Where(x => x.Deleted == false).ToList();


            }
            catch
            {
                throw;
            }
        }

       

        public MessageEnum JobOpeningDelete(int jobOpeningId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.JobOpenings.Where(x => x.JobOpeningId == jobOpeningId).FirstOrDefault();
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

        public MessageEnum JobOpeningUpdate(JobOpeningDTO jobOpeningDTO)
        {
            try
            {
                var jobOpening = _Context.JobOpenings.Where(x => x.JobOpeningId != jobOpeningDTO.JobOpeningId && x.Deleted == false).FirstOrDefault();
                if (jobOpening == null)
                {
                    var a = _Context.JobOpenings.Where(x => x.JobOpeningId == jobOpeningDTO.JobOpeningId).FirstOrDefault();
                    if (a != null)
                    {
                        a.JobTitle = jobOpeningDTO.JobTitle;
                        a.DepartmentId = jobOpeningDTO.DepartmentId;
                        a.DesignationId = jobOpeningDTO.DesignationId;
						a.SkillSetId = jobOpeningDTO.SkillSetId;
						a.Status = jobOpeningDTO.Status;
                        a.Description = jobOpeningDTO.Description;
                        a.SalaryLowerRange = jobOpeningDTO.SalaryLowerRange;
                        a.SalaryUpperRange = jobOpeningDTO.SalaryUpperRange;
                        a.UpdatedBy = jobOpeningDTO.CreatedBy;
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
    }
}
