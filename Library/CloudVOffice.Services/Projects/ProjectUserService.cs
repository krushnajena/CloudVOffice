using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectUserService : IProjectUserService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ProjectUser> _projectUserRepo;
		public ProjectUserService(ApplicationDBContext Context, ISqlRepository<ProjectUser> projectUserRepo)
		{

			_Context = Context;
			_projectUserRepo = projectUserRepo;
		}
		public ProjectUser GetProjectUserByProjectUserId(Int64 projectUserId)
		{
			try
			{
				return _Context.ProjectUsers.Where(x => x.ProjectUserId == projectUserId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectUser> GetProjectUsers()
		{
			try
			{
				return _Context.ProjectUsers.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectUser> GetProjectUsersByProjectId(int ProjectId)
		{
			try
			{
				return _Context.ProjectUsers
					.Include(c=>c.User)
					.Where(x=>x.ProjectId ==  ProjectId &&x.Deleted == false).ToList();
			}
			catch { throw; }
		}

		public MennsageEnum ProjectUserCreate(ProjectUserDTO projectUserDTO)
		{
			var objCheck = _Context.ProjectUsers.SingleOrDefault(opt => opt.ProjectUserId == projectUserDTO.ProjectUserId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					ProjectUser projectUser = new ProjectUser();
					projectUser.ProjectId = int.Parse( projectUserDTO.ProjectId.ToString());
					projectUser.UserId = projectUserDTO.UserId;

					projectUser.CreatedBy = Int64.Parse( projectUserDTO.CreatedBy.ToString());
					var obj = _projectUserRepo.Insert(projectUser);

					return MennsageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MennsageEnum.Duplicate;
				}

				return MennsageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}

		}

		public MennsageEnum ProjectUserDelete(Int64 projectUserId, Int64 DeletedBy)
		{

			try
			{
				var a = _Context.ProjectUsers.Where(x => x.ProjectUserId == projectUserId).FirstOrDefault();
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

		public MennsageEnum ProjectUserUpdate(ProjectUserDTO projectUserDTO)
		{

			try
			{
				
					var a = _Context.ProjectUsers.Where(x => x.ProjectUserId == projectUserDTO.ProjectUserId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectId = int.Parse( projectUserDTO.ProjectId.ToString());
					    a.UserId = projectUserDTO.UserId;
					    a.UpdatedBy = projectUserDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;
						_Context.SaveChanges();
						return MennsageEnum.Updated;
					}
					else
						return MennsageEnum.Invalid;
				

			}
			catch
			{
				throw;
			}
		}
	}
}
