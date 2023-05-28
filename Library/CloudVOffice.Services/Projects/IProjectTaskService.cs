using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public interface IProjectTaskService
	{
		public MennsageEnum ProjectTaskCreate(ProjectTaskDTO projectTaskDTO);
		public List<ProjectTask> GetProjectTasks();
		public ProjectTask GetProjectTaskByProjectTaskId(Int64 projectTaskId);
		public ProjectTask GetProjectTaskByTaskName(string taskName);
		public MennsageEnum ProjectTaskUpdate(ProjectTaskDTO projectTaskDTO);
		public MennsageEnum ProjectTaskDelete(Int64 projectTaskId, Int64 DeletedBy);

        public List<ProjectTask> ProjectTaskByProjectId(int ProjectId);
		public List<ProjectTask> GroupProjectTaskByProjectId(int ProjectId);
		public List<ProjectTask> NotCanceledTasksByProjectId(int projectId);

		public List<ProjectTask> GetTaskComplitedByOthersReport( Int64? Userid, Int64? EmployeeId);
		public List<ProjectTask> GetTaskDelayReport(Int64? Userid, Int64? EmployeeId);
		public List<ProjectTask> GetMyTaskDelayList(Int64? EmployeeId);

       
        public List<ProjectTask> GetMYTaskComplitedByOthersReport( Int64? EmployeeId);
        public List<ProjectTask> GetTasksForDelayValidation(Int64? Userid, Int64? EmployeeId);

		public MennsageEnum ProjectTaskStatusUpdate(ProjectTaskDTO projectTaskDTO);

	}
}
