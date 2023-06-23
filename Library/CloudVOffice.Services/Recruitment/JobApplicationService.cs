using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.Recruitment
{
	public class JobApplicationService : IJobApplicationService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<JobApplication> _jobApplicationRepo;
		public JobApplicationService(ApplicationDBContext Context, ISqlRepository<JobApplication> jobApplicationRepo)
		{

			_Context = Context;
			_jobApplicationRepo = jobApplicationRepo;
		}
		public MessageEnum JobApplicationCreate(JobApplicationDTO jobApplicationDTO)
		{
			var objCheck = _Context.JobApplications.SingleOrDefault(opt => opt.JobApplicationId == jobApplicationDTO.JobApplicationId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					JobApplication jobApplication = new JobApplication();
					jobApplication.JobId = jobApplicationDTO.JobId;
					jobApplication.ApplicantName = jobApplicationDTO.ApplicantName;
					jobApplication.EmailAddress = jobApplicationDTO.EmailAddress;
					jobApplication.PhoneNo = jobApplicationDTO.PhoneNo;
					jobApplication.JobApplicationSourceId = jobApplicationDTO.JobApplicationSourceId;
					jobApplication.TagDescription = jobApplicationDTO.TagDescription;
					jobApplication.CV = jobApplicationDTO.CV;
					jobApplication.SalaryExpectation = jobApplicationDTO.SalaryExpectation;
					jobApplication.SalaryExpectationLowerRange = jobApplicationDTO.SalaryExpectationLowerRange;
					jobApplication.CreatedBy = jobApplicationDTO.CreatedBy;
					var obj = _jobApplicationRepo.Insert(jobApplication);

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

		public JobApplication GetJobApplicationById(Int64 JobApplicationId)
		{
			try
			{
				return _Context.JobApplications.Where(x => x.JobApplicationId == JobApplicationId && x.Deleted == false).SingleOrDefault();

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

		public MessageEnum JobApplicationDelete(Int64 jobApplicationSourceId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.JobApplicationSources.Where(x => x.JobApplicationSourceId == jobApplicationSourceId).FirstOrDefault();
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
				var jobApplication = _Context.JobApplications.Where(x => x.JobApplicationId != jobApplicationDTO.JobApplicationId && x.ApplicantName == jobApplicationDTO.ApplicantName && x.Deleted == false).FirstOrDefault();
				if (jobApplication == null)
				{
					var a = _Context.JobApplications.Where(x => x.JobApplicationId == jobApplicationDTO.JobApplicationId).FirstOrDefault();
					if (a != null)
					{
						a.JobId = jobApplicationDTO.JobId;
						a.ApplicantName = jobApplicationDTO.ApplicantName;
						a.EmailAddress = jobApplicationDTO.EmailAddress;
						a.PhoneNo = jobApplicationDTO.PhoneNo;
						a.JobApplicationSourceId = jobApplicationDTO.JobApplicationSourceId;
						a.TagDescription = jobApplicationDTO.TagDescription;
						a.CV = jobApplicationDTO.CV;
						a.SalaryExpectation = jobApplicationDTO.SalaryExpectation;
						a.SalaryExpectationLowerRange = jobApplicationDTO.SalaryExpectationLowerRange;
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
	}
}
