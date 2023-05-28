	using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
					projectTask.EmployeeId = projectTaskDTO.EmployeeId;
					projectTask.AssignedBy = projectTaskDTO.AssignedBy;
					projectTask.AssignedOn = System.DateTime.Now;

					projectTask.TaskName = projectTaskDTO.TaskName;
					projectTask.Priority = projectTaskDTO.Priority;
					projectTask.ParentTaskId = projectTaskDTO.ParentTaskId;
					projectTask.IsGroup = projectTaskDTO.IsGroup;
					projectTask.ExpectedStartDate = projectTaskDTO.ExpectedStartDate;
					projectTask.ExpectedEndDate = projectTaskDTO.ExpectedEndDate;
					projectTask.ExpectedTimeInHours = projectTaskDTO.ExpectedTimeInHours;
					projectTask.Progress = projectTaskDTO.Progress;
					projectTask.TaskDescription = projectTaskDTO.TaskDescription;
					projectTask.TaskStatus = projectTaskDTO.TaskStatus;
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
						//a.ComplitedBy = projectTaskDTO.ComplitedBy;
						//a.ComplitedOn = projectTaskDTO.ComplitedOn;
						//a.TotalHoursByTimeSheet = projectTaskDTO.TotalHoursByTimeSheet;
						//a.TotalBillableHourByTimeSheet = projectTaskDTO.TotalBillableHourByTimeSheet;
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
                   
					.Include(f=>f.AssignedTo)
                    .Where(x => x.ProjectId == ProjectId && x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

		public List<ProjectTask> GroupProjectTaskByProjectId(int ProjectId)
		{
			try
			{
				return _Context.ProjectTasks

					.Where(x => x.ProjectId == ProjectId && x.Deleted == false && x.IsGroup == true).ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> NotCanceledTasksByProjectId(int projectId)
		{
			try
			{
				return _Context.ProjectTasks

					.Include(a => a.Project)

					.Include(f => f.Employee)
					.Where(x => x.ProjectId == projectId && x.Deleted == false && x.TaskStatus !="Canceled").ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> GetTaskComplitedByOthersReport(Int64? Userid, Int64? EmployeeId)
		{
			try
			{
				
				return  _Context.ProjectTasks
						.Include(a=>a.Project)
						.ThenInclude(a=>a.ProjectEmployees)
						.Include(a => a.Project)
						.ThenInclude(x => x.ProjectUsers)
						.Include(a=>a.Employee)
						.Include(a=>a.AssignedTo)
					

					
					.Where(x => x.Deleted == false &&  (
					x.Project.ProjectManager == EmployeeId
					|| x.Project.ProjectEmployees.Any(d=>d.EmployeeId == EmployeeId && d.Deleted == false) 
					|| x.Project.ProjectUsers.Any(d=>d.UserId == Userid && d.Deleted == false))
					&& x.EmployeeId != x.ComplitedBy
					).ToList();

			}
			catch
			{
				throw;
			}

		}

		public List<ProjectTask> GetTaskDelayReport(Int64? Userid, Int64? EmployeeId)
		{
			try
			{
			      return _Context.ProjectTasks
						.Include(a => a.Project)
						.ThenInclude(a => a.ProjectEmployees)
						.Include(a => a.Project)
						.ThenInclude(x => x.ProjectUsers)
						.Include(a => a.Employee)
						.Include(a => a.AssignedTo)



					.Where(x => x.Deleted == false && (
					x.Project.ProjectManager == EmployeeId
					|| x.Project.ProjectEmployees.Any(d => d.EmployeeId == EmployeeId && d.Deleted == false)
					|| x.Project.ProjectUsers.Any(d => d.UserId == Userid && d.Deleted == false)) && x.ExpectedEndDate < x.ComplitedOn).ToList();


			}
			catch
			{
				throw;
			}
		}

        public MennsageEnum ProjectTaskStatusUpdate(ProjectTaskDTO projectTaskDTO)
        {
			try
			{
				var projectTask = _Context.ProjectTasks.Where(x=>x.ProjectTaskId== projectTaskDTO.ProjectId).FirstOrDefault();
				projectTask.TaskStatus  = projectTaskDTO.TaskStatus;
				projectTask.UpdatedBy = projectTaskDTO.CreatedBy;
				projectTask.UpdatedDate = System.DateTime.Now;	
				if(projectTask.TaskStatus == "Open")
				{
					projectTask.Progress = 0;

                }
				else if (projectTask.TaskStatus == "Working")
                {
                    projectTask.Progress = 30;

                }
                else if (projectTask.TaskStatus == "PendingReview")
                {
                    projectTask.Progress = 80;

                }
                else if (projectTask.TaskStatus == "Completed")
                {
                    projectTask.Progress = 100;
                    projectTask.ComplitedBy = projectTaskDTO.EmployeeId;
                    projectTask.ComplitedOn = DateTime.Now;

                }
                _Context.SaveChanges();
				return MennsageEnum.Success;

            }
			catch
			{
				throw;
			}
        }
      

       

		public List<ProjectTask> GetMYTaskComplitedByOthersReport( Int64? EmployeeId)

		{
			throw new NotImplementedException();
		}


        public List<ProjectTask> GetTasksForDelayValidation(Int64? Userid, Int64? EmployeeId)
		{
            try
            {
                return _Context.ProjectTasks
                      .Include(a => a.Project)
                      .ThenInclude(b => b.ProjectEmployees)
                      .Include(c => c.Project)
                      .ThenInclude(x => x.ProjectUsers)
                      .Include(a => a.Employee)
                   



                  .Where(x => x.Deleted == false && 
                  x.Project.ProjectManager == EmployeeId && x.ComplitedOn> x.ExpectedEndDate).ToList();


            }
            catch
            {
                throw;
            }


        }

		public List<ProjectTask> GetMyTaskDelayList(Int64? EmployeeId)
		{

			try
			{
				return _Context.ProjectTasks
					  .Include(a => a.Project)
					  .ThenInclude(a => a.ProjectEmployees)
					  .Include(a => a.Employee)
					  .Include(a => a.AssignedTo)



				  .Where(x => x.Deleted == false && (
				  x.Project.ProjectEmployees.Any(d => d.EmployeeId == EmployeeId && d.Deleted == false && x.ExpectedEndDate < x.ComplitedOn))).ToList();


			}
			catch
			{
				throw;
			}
		}

    }
}
	