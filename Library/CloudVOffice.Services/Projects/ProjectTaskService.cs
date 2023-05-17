	using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectTaskService : IProjectTaskService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ProjectTask> _projectTaskRepo;
		public ProjectTaskService(ApplicationDBContext Context, ISqlRepository<ProjectTask> projectTaskRepo)
		{

			_Context = Context;
			_projectTaskRepo = projectTaskRepo;
		}
		public MennsageEnum ProjectTaskCreate(ProjectTaskDTO projectTaskDTO)
		{
			var objCheck = _Context.ProjectTasks.SingleOrDefault(opt => opt.ProjectTaskId == projectTaskDTO.ProjectTaskId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					ProjectTask projectTask = new ProjectTask();
					projectTask.ProjectId = projectTaskDTO.ProjectId;
					projectTask.TaskName = projectTaskDTO.TaskName;
					projectTask.Priority = projectTaskDTO.Priority;
					projectTask.ParentTaskId = projectTaskDTO.ParentTaskId;
					projectTask.IsGroup = projectTaskDTO.IsGroup;
					projectTask.ExpectedStartDate = projectTaskDTO.ExpectedStartDate;
					projectTask.ExpectedEndDate = projectTaskDTO.ExpectedEndDate;
					projectTask.ExpectedTimeInHours = projectTaskDTO.ExpectedTimeInHours;
					projectTask.Progress = projectTaskDTO.Progress;
					projectTask.TaskDescription = projectTaskDTO.TaskDescription;
					projectTask.ComplitedBy = projectTaskDTO.ComplitedBy;
					projectTask.ComplitedOn = projectTaskDTO.ComplitedOn;
					projectTask.TotalHoursByTimeSheet = projectTaskDTO.TotalHoursByTimeSheet;
					projectTask.TotalBillableHourByTimeSheet = projectTaskDTO.TotalBillableHourByTimeSheet;
					projectTask.CreatedBy = projectTaskDTO.CreatedBy;
					var obj = _projectTaskRepo.Insert(projectTask);

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
		public ProjectTask GetProjectTaskByProjectTaskId(Int64 projectTaskId)
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public ProjectTask GetProjectTaskByTaskName(string taskName)
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.TaskName == taskName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> GetProjectTasks()
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		

		public MennsageEnum ProjectTaskDelete(Int64 projectTaskId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskId).FirstOrDefault();
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

		public MennsageEnum ProjectTaskUpdate(ProjectTaskDTO projectTaskDTO)
		{
			try
			{
				var projectTask = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskDTO.ProjectTaskId && x.TaskName == projectTaskDTO.TaskName && x.Deleted == false).FirstOrDefault();
				if (projectTask == null)
				{
					var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskDTO.ProjectTaskId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectId = projectTaskDTO.ProjectId;
						a.TaskName = projectTaskDTO.TaskName;
						a.Priority = projectTaskDTO.Priority;
						a.ParentTaskId = projectTaskDTO.ParentTaskId;
						a.IsGroup = projectTaskDTO.IsGroup;
						a.ExpectedStartDate = projectTaskDTO.ExpectedStartDate;
						a.ExpectedEndDate = projectTaskDTO.ExpectedEndDate;
						a.ExpectedTimeInHours = projectTaskDTO.ExpectedTimeInHours;
						a.Progress = projectTaskDTO.Progress;
						a.TaskDescription = projectTaskDTO.TaskDescription;
						a.ComplitedBy = projectTaskDTO.ComplitedBy;
						a.ComplitedOn = projectTaskDTO.ComplitedOn;
						a.TotalHoursByTimeSheet = projectTaskDTO.TotalHoursByTimeSheet;
						a.TotalBillableHourByTimeSheet = projectTaskDTO.TotalBillableHourByTimeSheet;
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

        public List<ProjectTask> ProjectTaskByProjectId(int ProjectId)
        {
            try
            {
                return _Context.ProjectTasks
					
					.Include(a=>a.Project)
                    .Include(x => x.TaskAssignments)
					.ThenInclude(f=>f.Employee)
                    .Where(x => x.ProjectId == ProjectId && x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
	