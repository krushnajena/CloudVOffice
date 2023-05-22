using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectActivityTypeService : IProjectActivityTypeService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ProjectActivityType> _projectActivityTypeRepo;
		public ProjectActivityTypeService(ApplicationDBContext Context, ISqlRepository<ProjectActivityType> projectActivityTypeRepo)
		{

			_Context = Context;
			_projectActivityTypeRepo = projectActivityTypeRepo;
		}
		public ProjectActivityType GetProjectActivityTypeByProjectActivityName(string projectActivityName)
		{
			try
			{
				return _Context.ProjectActivityTypes.Where(x => x.ProjectActivityName == projectActivityName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public ProjectActivityType GetProjectActivityTypeByProjectActivityTypeId(Int64 projectActivityTypeId)
		{
			try
			{
				return _Context.ProjectActivityTypes.Where(x => x.ProjectActivityTypeId == projectActivityTypeId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectActivityType> GetProjectActivityTypes()
		{
			try
			{
				return _Context.ProjectActivityTypes.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectActivityType> GetProjectActivityTypesByActivityCategory(string activityCategory)
		{
			try
			{
				return _Context.ProjectActivityTypes.Where(x => x.Deleted == false && x.ActivityCategory == activityCategory).ToList();
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum ProjectActivityTypeCreate(ProjectActivityTypeDTO projectActivityTypeDTO)
		{

			try
			{
				var projectActivityType = _Context.ProjectActivityTypes.Where(x => x.ProjectActivityName == projectActivityTypeDTO.ProjectActivityName && x.Deleted == false).FirstOrDefault();
				if (projectActivityType == null)
				{
					_projectActivityTypeRepo.Insert(new ProjectActivityType()
					{
						ProjectActivityName = projectActivityTypeDTO.ProjectActivityName,
						ActivityCategory = projectActivityTypeDTO.ActivityCategory,
						CreatedBy = projectActivityTypeDTO.CreatedBy,
						CreatedDate = DateTime.Now,
						Deleted = false
					});
					return MennsageEnum.Success;
				}
				else
					return MennsageEnum.Duplicate;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum ProjectActivityTypeDelete(Int64 projectActivityTypeId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.ProjectActivityTypes.Where(x => x.ProjectActivityTypeId == projectActivityTypeId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MennsageEnum.Deleted;
				}
				else
					return MennsageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum ProjectActivityTypeUpdate(ProjectActivityTypeDTO projectActivityTypeDTO)
		{
			try
			{
				var projectActivityType = _Context.ProjectActivityTypes.Where(x => x.ProjectActivityTypeId != projectActivityTypeDTO.ProjectActivityTypeId && x.ProjectActivityName == projectActivityTypeDTO.ProjectActivityName && x.Deleted == false).FirstOrDefault();
				if (projectActivityType == null)
				{
					var a = _Context.ProjectActivityTypes.Where(x => x.ProjectActivityTypeId == projectActivityTypeDTO.ProjectActivityTypeId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectActivityName = projectActivityTypeDTO.ProjectActivityName;
						a.UpdatedBy = projectActivityTypeDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;
						a.ActivityCategory = projectActivityTypeDTO.ActivityCategory;
						_Context.SaveChanges();
						return MennsageEnum.Updated;
					}
					else
						return MennsageEnum.Invalid;
				}
				else
				{
					return MennsageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}
		}
	}
}
