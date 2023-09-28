using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class CandidateService : ICandidateService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<Candidate> _candidateRepo;
        private readonly ICandidateSkillService _candidateSkillService;

        public CandidateService(ApplicationDBContext Context, ISqlRepository<Candidate> candidateRepo, ICandidateSkillService candidateSkillService)
		{
			_Context = Context;
			_candidateRepo = candidateRepo;
            _candidateSkillService = candidateSkillService;
        }

		public MessageEnum CandidateCreate(CandidateDTO candidateDTO)
		{
			var objCheck = _Context.Candidates.SingleOrDefault(x => x.CandidateId == candidateDTO.CandidateId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					Candidate candidate = new Candidate();
					candidate.FirstName = candidateDTO.FirstName;
					candidate.MiddleName = candidateDTO.MiddleName;
					candidate.LastName = candidateDTO.LastName;
					candidate.Email = candidateDTO.Email;
					candidate.MobileNo = candidateDTO.MobileNo;
					candidate.StreetAddress = candidateDTO.StreetAddress;
					candidate.City = candidateDTO.City;
					candidate.ExperienceinYears = candidateDTO.ExperienceinYears;
					candidate.HighestQualification = candidateDTO.HighestQualification;
					candidate.CurrentJob = candidateDTO.CurrentJob;
					candidate.CurrentEmployer = candidateDTO.CurrentEmployer;
					candidate.ExpectedSalary = candidateDTO.ExpectedSalary;
					candidate.CurrentSalary = candidateDTO.CurrentSalary;
					candidate.Cv = candidateDTO.Cv;
					candidate.ApplicationSourceId = candidateDTO.ApplicationSourceId;
					candidate.Status = candidateDTO.Status;
					candidate.CreatedBy = candidateDTO.CreatedBy;
					var obj = _candidateRepo.Insert(candidate);
					for (int i = 0; i < candidateDTO.Skills.Count; i++)
					{
						_candidateSkillService.CreateCandidateSkill((int)obj.CandidateId, candidateDTO.Skills[i],candidateDTO.CreatedBy);

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

        public MessageEnum CandidateDelete(Int64 candidateId, Int64 DeletedBy)
        {
			try
			{
				var a = _Context.Candidates.Where(x => x.CandidateId == candidateId).FirstOrDefault();
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

        public MessageEnum CandidateUpdate(CandidateDTO candidateDTO)
		{
			try
			{
				var candidate = _Context.Candidates.Where(x => x.CandidateId != candidateDTO.CandidateId && x.FirstName == candidateDTO.FirstName && x.MiddleName == candidateDTO.MiddleName && x.LastName == candidateDTO.LastName && x.Deleted == false).FirstOrDefault();
				if (candidate == null)
				{
					var a = _Context.Candidates.Where(x => x.CandidateId == candidateDTO.CandidateId).FirstOrDefault();
					if (a != null)
					{
						a.FirstName = candidateDTO.FirstName;
						a.MiddleName = candidateDTO.MiddleName;
						a.LastName = candidateDTO.LastName;
						a.Email = candidateDTO.Email;
						a.MobileNo = candidateDTO.MobileNo;
						a.StreetAddress = candidateDTO.StreetAddress;
						a.City = candidateDTO.City;
						a.ExperienceinYears = candidateDTO.ExperienceinYears;
						a.HighestQualification = candidateDTO.HighestQualification;
						a.CurrentJob = candidateDTO.CurrentJob;
						a.CurrentEmployer = candidateDTO.CurrentEmployer;
						a.ExpectedSalary = candidateDTO.ExpectedSalary;
						a.CurrentSalary = candidateDTO.CurrentSalary;
						a.Cv = candidateDTO.Cv;
						a.ApplicationSourceId = candidateDTO.ApplicationSourceId;
						a.Status = candidateDTO.Status;
						a.UpdatedBy = candidateDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;

						_Context.SaveChanges();
						for (int i = 0; i < candidateDTO.Skills.Count; i++) 
						{
                            _candidateSkillService.CreateCandidateSkill((int)candidateDTO.CandidateId, candidateDTO.Skills[i], candidateDTO.CreatedBy);
                        }
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

		public Candidate GetCandidateById(Int64 candidateId)
		{
			return _Context.Candidates.Include(x=>x.CandidateSkills.Where(a=>a.Deleted == false)).Where(x => x.CandidateId == candidateId && x.Deleted == false).SingleOrDefault();
		}

		public List<Candidate> GetCandidateList()
		{
			try
			{
				return _Context.Candidates
					.Include(x => x.JobApplicationSource)
					.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}
	}
}
