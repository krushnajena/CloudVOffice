using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class SkillSetService : ISkillSetService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<SkillSet> _skillSetRepo;
		public SkillSetService(ApplicationDBContext Context, ISqlRepository<SkillSet> skillSetRepo)
		{

			_Context = Context;
			_skillSetRepo = skillSetRepo;
		}

		public MessageEnum CreateSkillSet(SkillSetDTO skillSetDTO)
		{
			var objCheck = _Context.SkillSets.SingleOrDefault(x => x.SkillSetId == skillSetDTO.SkillSetId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					SkillSet skillSet = new SkillSet();

					skillSet.SkillName = skillSetDTO.SkillName;
					skillSet.SkillDescription = skillSetDTO.SkillDescription;
					skillSet.CreatedBy = skillSetDTO.CreatedBy;
					var obj = _skillSetRepo.Insert(skillSet);
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

		public SkillSet GetSkillSetById(int skillSetId)
		{
			try
			{
				return _Context.SkillSets.Where(x => x.SkillSetId == skillSetId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;

			}
		}

		

		public List<SkillSet> GetSkillSetList()
		{
			try
			{
				return _Context.SkillSets.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum SkillSeteDelete(int skillSetId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.SkillSets.Where(x => x.SkillSetId == skillSetId).FirstOrDefault();
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

		public MessageEnum SkillSetUpdate(SkillSetDTO skillSetDTO)
		{
			try
			{
				var sikillset = _Context.SkillSets.Where(x => x.SkillSetId != skillSetDTO.SkillSetId && x.Deleted == false).FirstOrDefault();
				if (sikillset == null)
				{
					var a = _Context.SkillSets.Where(x => x.SkillSetId == skillSetDTO.SkillSetId).FirstOrDefault();
					if (a != null)
					{
						
						a.SkillName = skillSetDTO.SkillName;
						a.SkillDescription = skillSetDTO.SkillDescription;
						a.UpdatedBy = skillSetDTO.CreatedBy;
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
