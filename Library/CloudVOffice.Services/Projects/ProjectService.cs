using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectService : IProjectService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<Project> _projectRepo;

		private readonly IProjectUserService _projectUserService;

		private readonly IProjectEmployeeService _projectEmployeeService;
		public ProjectService(ApplicationDBContext Context, ISqlRepository<Project> projectRepo,
			 IProjectEmployeeService projectEmployeeService,
			 IProjectUserService projectUserService
			)
		{

			_Context = Context;
			_projectRepo = projectRepo;
			_projectUserService = projectUserService;
			_projectEmployeeService = projectEmployeeService;
		}

		public List<Project> GetMyAssignedProject(Int64 EmployeeId, Int64 UserId)
		{
			try
			{
				return _Context.Projects
					.Include(e=>e.Employee)
					.Include(s=>s.ProjectEmployees)
					.Include(t=>t.ProjectUsers)
					.Where(x => x.Deleted == false && ( x.ProjectManager == EmployeeId
					|| x.ProjectEmployees.Any(d=>d.EmployeeId == EmployeeId && d.Deleted == false)
					|| x.ProjectUsers.Any(d => d.UserId == UserId && d.Deleted == false))
					).ToList();
			}
			catch
			{
				throw;
			}
		}

		public Project GetProjectByProjectId(Int64 projectId)
		{
			try
			{
				return _Context.Projects.Where(x => x.ProjectId == projectId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public Project GetProjectByProjectName(string projectName)
		{
			try
			{
				return _Context.Projects.Where(x => x.ProjectName == projectName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<Project> GetProjects()
		{
			try
			{
				return _Context.Projects
					.Include(x=>x.ProjectType)
					.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

			

		public MennsageEnum ProjectCreate(ProjectDTO projectDTO)
		{
			var objCheck = _Context.Projects.SingleOrDefault(opt => opt.ProjectId == projectDTO.ProjectId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					Project project = new Project();
					project.ProjectCode = projectDTO.ProjectCode;
					project.ProjectName = projectDTO.ProjectName;
					project.StartDate = projectDTO.StartDate;
					project.EndDate = projectDTO.EndDate;
					project.Status = projectDTO.Status;
					project.ProjectTypeId = projectDTO.ProjectTypeId;
					project.Priority = projectDTO.Priority;
					project.CompleteMethod = projectDTO.CompleteMethod;
					project.CustomerId = projectDTO.CustomerId;
					project.SalesOrderId = projectDTO.SalesOrderId;
					project.ProjectNotes = projectDTO.ProjectNotes;
					project.EstimatedCost = projectDTO.EstimatedCost;
					project.ProjectManager = projectDTO.ProjectManager;
					project.CreatedBy = projectDTO.CreatedBy;
					var obj = _projectRepo.Insert(project);
					var projectEmployee = JsonConvert.DeserializeObject<List<ProjectEmployeeDTO>>(projectDTO.ProjectEmployeeString);

					for (int i = 0; i < projectEmployee.Count; i++)
					{
						projectEmployee[i].CreatedBy = projectDTO.CreatedBy;
						projectEmployee[i].ProjectId = obj.ProjectId;
					
						_projectEmployeeService.ProjectEmployeeCreate(projectEmployee[i]);
					}


					var projectUser = JsonConvert.DeserializeObject<List<ProjectUserDTO>>(projectDTO.ProjectUsersString);

					for (int i = 0; i < projectUser.Count; i++)
					{
						projectUser[i].CreatedBy = projectDTO.CreatedBy;
						projectUser[i].ProjectId = obj.ProjectId;
						_projectUserService.ProjectUserCreate(projectUser[i]);
					}
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

		public MennsageEnum ProjectDelete(Int64 projectId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.Projects.Where(x => x.ProjectId == projectId).FirstOrDefault();
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

		public MennsageEnum ProjectUpdate(ProjectDTO projectDTO)
		{
			try
			{
				var project = _Context.Projects.Where(x => x.ProjectId == projectDTO.ProjectId && x.ProjectCode == projectDTO.ProjectCode && x.Deleted == false).FirstOrDefault();
				if (project == null)
				{
					var a = _Context.Projects.Where(x => x.ProjectId == projectDTO.ProjectId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectCode = projectDTO.ProjectCode;
						a.ProjectName = projectDTO.ProjectName;
						a.StartDate = projectDTO.StartDate;
						a.EndDate = projectDTO.EndDate;
						a.Status = projectDTO.Status;
						a.ProjectTypeId = projectDTO.ProjectTypeId;
						a.Priority = projectDTO.Priority;
						a.CompleteMethod = projectDTO.CompleteMethod;
						a.CustomerId = projectDTO.CustomerId;
						a.SalesOrderId = projectDTO.SalesOrderId;
						a.ProjectNotes = projectDTO.ProjectNotes;
						a.EstimatedCost = projectDTO.EstimatedCost;
						a.ProjectManager = projectDTO.ProjectManager;
						a.UpdatedDate = DateTime.Now;
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
