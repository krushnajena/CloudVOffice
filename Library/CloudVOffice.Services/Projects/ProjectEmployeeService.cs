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
	public class ProjectEmployeeService : IProjectEmployeeService
	{

		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ProjectEmployee> _projectEmployeeRepo;
		public ProjectEmployeeService(ApplicationDBContext Context, ISqlRepository<ProjectEmployee> projectEmployeeRepo)
		{

			_Context = Context;
			_projectEmployeeRepo = projectEmployeeRepo;
		}

		public ProjectEmployee GetProjectEmployeeByFullName(string fullName)
		{
			try
			{
				return _Context.ProjectEmployees.Where(x => x.FullName == fullName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public ProjectEmployee GetProjectEmployeeByProjectEmployeeId(Int64 projectEmployeeId)
		{
			try
			{
				return _Context.ProjectEmployees.Where(x => x.ProjectEmployeeId == projectEmployeeId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public ProjectEmployee GetProjectEmployeeByProjectId(int projectId)
		{
			try
			{
				return _Context.ProjectEmployees.Where(x => x.ProjectId == projectId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectEmployee> GetProjectEmployees()
		{
			try
			{
				return _Context.ProjectEmployees.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum ProjectEmployeeCreate(ProjectEmployeeDTO projectEmployeeDTO)
		{

			var objCheck = _Context.ProjectEmployees.SingleOrDefault(opt => opt.EmployeeId == projectEmployeeDTO.EmployeeId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					ProjectEmployee projectEmployee = new ProjectEmployee();
					
					projectEmployee.ProjectId = projectEmployeeDTO.ProjectId;
					projectEmployee.CreatedBy = projectEmployeeDTO.CreatedBy;
					var obj = _projectEmployeeRepo.Insert(projectEmployee);

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

		public MennsageEnum ProjectEmployeeDelete(Int64 projectEmployeeId, Int64 DeletedBy)
		{

			try
			{
				var a = _Context.ProjectEmployees.Where(x => x.ProjectEmployeeId == projectEmployeeId).FirstOrDefault();
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

		public MennsageEnum ProjectEmployeeUpdate(ProjectEmployeeDTO projectEmployeeDTO)
		{
			try
			{

				var a = _Context.ProjectEmployees.Where(x => x.EmployeeId == projectEmployeeDTO.EmployeeId).FirstOrDefault();
				if (a != null)
				{
					
					a.ProjectId = projectEmployeeDTO.ProjectId;
					a.UpdatedBy = projectEmployeeDTO.CreatedBy;
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