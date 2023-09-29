using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Recruitment.JO
{
    public class JobOpeningService : IJobOpeningService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<JobOpening> _jobOpeningRepo;
        private readonly IJobOpeningSkillService _jobOpeningSkillService;
        private readonly IJobOpeningTagService _jobOpeningTagService;
        public JobOpeningService(ApplicationDBContext Context, ISqlRepository<JobOpening> jobOpeningRepo,
             IJobOpeningSkillService jobOpeningSkillService,
              IJobOpeningTagService jobOpeningTagService
             )
        {

            _Context = Context;
            _jobOpeningRepo = jobOpeningRepo;
            _jobOpeningSkillService = jobOpeningSkillService;
            _jobOpeningTagService = jobOpeningTagService;
        }
        public MessageEnum JobOpeningCreate(JobOpeningDTO jobOpeningDTO)
        {
            var objCheck = _Context.JobOpenings.SingleOrDefault(x => x.JobOpeningId == jobOpeningDTO.JobOpeningId && x.Deleted == false);
            try
            {
                if (objCheck == null)
                {
                    JobOpening jobOpening = new JobOpening();
                    jobOpening.JobOpType = jobOpeningDTO.JobOpType;
                    jobOpening.ClientID = jobOpeningDTO.ClientID;
                    jobOpening.ContactId = jobOpeningDTO.ContactId;
                    jobOpening.HiringManagerId = jobOpeningDTO.HiringManagerId;
                    jobOpening.JobTitle = jobOpeningDTO.JobTitle;
                    jobOpening.DateOpened = jobOpeningDTO.DateOpened;
                    jobOpening.TargetDate = jobOpeningDTO.TargetDate;
                    jobOpening.JobType = jobOpeningDTO.JobType;
                    jobOpening.WorkExperience = jobOpeningDTO.WorkExperience;
                    jobOpening.City = jobOpeningDTO.City;
                    jobOpening.RevenuePerPosition = jobOpeningDTO.RevenuePerPosition;
                    jobOpening.NumberofPositions = jobOpeningDTO.NumberofPositions;
                    jobOpening.ExpectedRevenue = jobOpeningDTO.ExpectedRevenue;
                    jobOpening.ActualRevenue = jobOpeningDTO.ActualRevenue;
                    jobOpening.Status = jobOpeningDTO.Status;
                    jobOpening.JobDescription = jobOpeningDTO.JobDescription;
                    jobOpening.Requirements = jobOpeningDTO.Requirements;
                    jobOpening.Benefits = jobOpeningDTO.Benefits;
                    jobOpening.PublishOnWebsite = jobOpeningDTO.PublishOnWebsite;
                    jobOpening.CreatedBy = jobOpeningDTO.CreatedBy;
                    var obj = _jobOpeningRepo.Insert(jobOpening);
                    for(int i = 0; i < jobOpeningDTO.Skills.Count; i++)
                    {
                        _jobOpeningSkillService.CreateJobOpeningSkill(obj.JobOpeningId, jobOpeningDTO.Skills[i], jobOpeningDTO.CreatedBy);
                    }

                    for (int i = 0; i < jobOpeningDTO.Tags.Count; i++)
                    {
                        _jobOpeningTagService.CreateJobOpeningTag(obj.JobOpeningId, jobOpeningDTO.Tags[i], jobOpeningDTO.CreatedBy);
                    }
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
                return _Context.JobOpenings
                    .Include(x=>x.JobOpeningTags.Where(n => n.Deleted == false))
                    .ThenInclude(a=>a.Employee)
                    .Include(x=>x.JobOpeningSkills.Where(n => n.Deleted == false))
                    .ThenInclude(a=>a.SkillSet)
                    .Include(x=>x.RecruitClient)
                      .Include(x => x.RecruitClientContact)
                      .Include(x=>x.Employee)
                    .Where(x => x.JobOpeningId == jobOpeningId && x.Deleted == false).SingleOrDefault();

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
                return _Context.JobOpenings
                    .Include(x => x.RecruitClient)
                    .Include(x => x.RecruitClientContact)
                    .Include(x => x.Employee)
                    .Include(x=>x.JobOpeningSkills.Where(a=>a.Deleted ==false))
                    .ThenInclude(x=>x.SkillSet)
                    .Include(x=>x.JobOpeningTags.Where(a => a.Deleted == false))
                    .ThenInclude(x=>x.Employee)
                    .Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }



        public MessageEnum JobOpeningDelete(int jobOpeningId, long DeletedBy)
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
                var a = _Context.JobOpenings.Where(x => x.JobOpeningId == jobOpeningDTO.JobOpeningId).FirstOrDefault();
                if (a != null)
                {
                    a.JobOpType = jobOpeningDTO.JobOpType;
                    a.ClientID = jobOpeningDTO.ClientID;
                    a.ContactId = jobOpeningDTO.ContactId;
                    a.HiringManagerId = jobOpeningDTO.HiringManagerId;
                    a.JobTitle = jobOpeningDTO.JobTitle;
                    a.DateOpened = jobOpeningDTO.DateOpened;
                    a.TargetDate = jobOpeningDTO.TargetDate;
                    a.JobType = jobOpeningDTO.JobType;
                    a.WorkExperience = jobOpeningDTO.WorkExperience;
                    a.City = jobOpeningDTO.City;
                    a.RevenuePerPosition = jobOpeningDTO.RevenuePerPosition;
                    a.NumberofPositions = jobOpeningDTO.NumberofPositions;
                    a.ExpectedRevenue = jobOpeningDTO.ExpectedRevenue;
                    a.ActualRevenue = jobOpeningDTO.ActualRevenue;
                    a.Status = jobOpeningDTO.Status;
                    a.JobDescription = jobOpeningDTO.JobDescription;
                    a.Requirements = jobOpeningDTO.Requirements;
                    a.Benefits = jobOpeningDTO.Benefits;
                    a.PublishOnWebsite = jobOpeningDTO.PublishOnWebsite;
                    a.UpdatedBy = jobOpeningDTO.CreatedBy;
                    a.UpdatedDate = DateTime.Now;

                    _Context.SaveChanges();
                    _jobOpeningSkillService.RemoveUnListedSkills(jobOpeningDTO.Skills, (int)jobOpeningDTO.JobOpeningId, jobOpeningDTO.CreatedBy);
                    for (int i = 0; i < jobOpeningDTO.Skills.Count; i++)
                    {
                        _jobOpeningSkillService.CreateJobOpeningSkill((int)jobOpeningDTO.JobOpeningId, jobOpeningDTO.Skills[i], jobOpeningDTO.CreatedBy);
                    }

                    _jobOpeningTagService.RemoveUnListedTags(jobOpeningDTO.Tags, (int)jobOpeningDTO.JobOpeningId, jobOpeningDTO.CreatedBy);
                    for (int i = 0; i < jobOpeningDTO.Tags.Count; i++)
                    {
                        _jobOpeningTagService.CreateJobOpeningTag((int)jobOpeningDTO.JobOpeningId, jobOpeningDTO.Tags[i], jobOpeningDTO.CreatedBy);
                    }

                    return MessageEnum.Updated;
                }
                else
                    return MessageEnum.Invalid;

            }
            catch
            {
                throw;
            }
        }
    }
}
