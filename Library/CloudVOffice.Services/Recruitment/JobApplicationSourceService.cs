using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class JobApplicationSourceService : IJobApplicationSourceService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<JobApplicationSource> _jobApplicationSourceRepo;
		public JobApplicationSourceService(ApplicationDBContext Context, ISqlRepository<JobApplicationSource> jobApplicationSourceRepo)
		{

			_Context = Context;
			_jobApplicationSourceRepo = jobApplicationSourceRepo;
		}
		public MessageEnum JobApplicationSourceCreate(JobApplicationSourceDTO jobApplicationSourceDTO)
		{
			var objCheck = _Context.JobApplicationSources.SingleOrDefault(opt => opt.JobApplicationSourceId == jobApplicationSourceDTO.JobApplicationSourceId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					JobApplicationSource jobApplicationSource = new JobApplicationSource();
					jobApplicationSource.SourceName = jobApplicationSourceDTO.SourceName;
					jobApplicationSource.CreatedBy = jobApplicationSourceDTO.CreatedBy;
					var obj = _jobApplicationSourceRepo.Insert(jobApplicationSource);

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

		public JobApplicationSource GetJobApplicationSourceByJobApplicationSourceId(Int64 jobApplicationSourceId)
		{
			try
			{
				return _Context.JobApplicationSources.Where(x => x.JobApplicationSourceId == jobApplicationSourceId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public JobApplicationSource GetJobApplicationSourceByName(string sourceName)
		{
			try
			{
				return _Context.JobApplicationSources.Where(x => x.SourceName == sourceName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<JobApplicationSource> GetJobApplicationSourceList()
		{

			try
			{
				return _Context.JobApplicationSources.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum JobApplicationSourceDelete(Int64 jobApplicationSourceId, Int64 DeletedBy)
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

		public MessageEnum JobApplicationSourceUpdate(JobApplicationSourceDTO jobApplicationSourceDTO)
		{
			try
			{
				var jobApplicationSourcee = _Context.JobApplicationSources.Where(x => x.JobApplicationSourceId != jobApplicationSourceDTO.JobApplicationSourceId && x.SourceName == jobApplicationSourceDTO.SourceName && x.Deleted == false).FirstOrDefault();
				if (jobApplicationSourcee == null)
				{
					var a = _Context.JobApplicationSources.Where(x => x.JobApplicationSourceId == jobApplicationSourceDTO.JobApplicationSourceId).FirstOrDefault();
					if (a != null)
					{
						a.SourceName = jobApplicationSourceDTO.SourceName;
						a.UpdatedBy = jobApplicationSourceDTO.CreatedBy;
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
