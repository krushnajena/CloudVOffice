using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
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
    public class CandidateSkillService : ICandidateSkillService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<CandidateSkill> _candidateSkillRepo;
       
        public CandidateSkillService(ApplicationDBContext Context, ISqlRepository<CandidateSkill> candidateSkillRepo)
        {
            _Context = Context;
            _candidateSkillRepo = candidateSkillRepo;
           
        }

        public MessageEnum CreateCandidateSkill(int candidateId, int SkillId, long createdBy)
        {
            var a = _Context.CandidateSkills.Where(x => x.SkillId == SkillId && x.CandidateId == candidateId && x.Deleted == false).ToList();
            if (a.Count == 0)
            {
                CandidateSkill skill = new CandidateSkill();
               
                skill.CandidateId = candidateId;
                skill.SkillId = SkillId;
                skill.CreatedBy = createdBy;
                skill.CreatedDate = DateTime.Now;
                _candidateSkillRepo.Insert(skill);
            }

            return MessageEnum.Success;
        }

       



        //	public MessageEnum CandidateSkillCreate(CandidateSkillDTO candidateSkillDTO)
        //	{
        //		var objCheck = _Context.CandidateSkills.SingleOrDefault(x => x.CandidateSkillId == candidateSkillDTO.CandidateId && x.Deleted == false);
        //		try
        //		{
        //			if (objCheck == null)
        //			{
        //				CandidateSkill candidateSkill = new CandidateSkill();


        //				candidateSkill.CandidateId = candidateSkillDTO.CandidateId;
        //				candidateSkill.SkillId = candidateSkillDTO.SkillId;
        //				candidateSkill.CreatedBy = candidateSkillDTO.CreatedBy;
        //				var obj = _candidateSkillRepo.Insert(candidateSkill);
        //				return MessageEnum.Success;
        //			}
        //			else if (objCheck != null)
        //			{
        //				return MessageEnum.Duplicate;
        //			}
        //			return MessageEnum.UnExpectedError;
        //		}
        //		catch
        //		{
        //			throw;
        //		}
        //	}

        //	public MessageEnum CandidateSkillDelete(Int64 candidateSkillId, Int64 DeletedBy)
        //	{
        //		try
        //		{
        //			var a = _Context.CandidateSkills.Where(x => x.CandidateSkillId == candidateSkillId).FirstOrDefault();
        //			if (a != null)
        //			{
        //				a.Deleted = true;
        //				a.UpdatedBy = DeletedBy;
        //				a.UpdatedDate = DateTime.Now;
        //				_Context.SaveChanges();
        //				return MessageEnum.Deleted;
        //			}
        //			else
        //				return MessageEnum.Invalid;
        //		}
        //		catch
        //		{
        //			throw;
        //		}
        //	}

        //	public MessageEnum CandidateSkillUpdate(CandidateSkillDTO candidateSkillDTO)
        //	{
        //		try
        //		{
        //			var sikillset = _Context.CandidateSkills.Where(x => x.CandidateSkillId != candidateSkillDTO.CandidateSkillId && x.Deleted == false).FirstOrDefault();
        //			if (sikillset == null)
        //			{
        //				var a = _Context.CandidateSkills.Where(x => x.CandidateSkillId == candidateSkillDTO.CandidateSkillId).FirstOrDefault();
        //				if (a != null)
        //				{

        //					a.CandidateId = candidateSkillDTO.CandidateId;
        //					a.SkillId = candidateSkillDTO.SkillId;
        //					a.UpdatedBy = candidateSkillDTO.CreatedBy;
        //					a.UpdatedDate = DateTime.Now;

        //					_Context.SaveChanges();
        //					return MessageEnum.Updated;
        //				}
        //				else
        //					return MessageEnum.Invalid;
        //			}
        //			else
        //			{
        //				return MessageEnum.Duplicate;
        //			}

        //		}
        //		catch
        //		{
        //			throw;
        //		}
        //	}





        //	public CandidateSkill GetCandidateSkillById(Int64 candidateSkillId)
        //	{
        //		return _Context.CandidateSkills.Where(x => x.CandidateSkillId == candidateSkillId && x.Deleted == false).SingleOrDefault();
        //	}

        //	public List<CandidateSkill> GetCandidateSkillList()
        //	{
        //		try
        //		{
        //			return _Context.CandidateSkills.Where(x => x.Deleted == false).ToList();

        //		}
        //		catch
        //		{
        //			throw;
        //		};
        //	}
        //}
    }
}
