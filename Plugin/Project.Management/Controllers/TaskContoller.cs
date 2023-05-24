using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Projects;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Management.Controllers
{
    [Area(AreaNames.Projects)]
    public class TaskController : BasePluginController
    {

        private readonly IProjectTaskService _projectTaskService;
		private readonly IProjectService _projectService;

		private readonly IEmployeeService _empolyeeService;
		
		public TaskController(IProjectTaskService projectTaskService ,IProjectService projectService, IEmployeeService empolyeeService)
        {

            _projectTaskService = projectTaskService;
            _projectService = projectService;
			_empolyeeService = empolyeeService;
		}
        public IActionResult Tasks(int ProjectId)
        {
            var a = _projectTaskService.ProjectTaskByProjectId(ProjectId);
            ViewBag.Tasks = a.AsEnumerable();
            return View("~/Plugins/Project.Management/Views/Task/Tasks.cshtml");
        }

        [HttpGet]
        public IActionResult TaskCreate(Int64? projectTaskId)
        {
            ProjectTaskDTO projectTaskDTO = new ProjectTaskDTO();
			Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			Int64 EmployeeId = _empolyeeService.GetEmployeeDetailsByUserId(UserId).EmployeeId;
            var projects = _projectService.GetMyAssignedProject(EmployeeId, UserId);
			


			if (projectTaskId != null)
            {

                ProjectTask d = _projectTaskService.GetProjectTaskByProjectTaskId(Int64.Parse(projectTaskId.ToString()));

                projectTaskDTO.ProjectId = d.ProjectId;
                projectTaskDTO.TaskName = d.TaskName;
                projectTaskDTO.Priority = d.Priority;
                projectTaskDTO.ParentTaskId = d.ParentTaskId;
                projectTaskDTO.IsGroup = d.IsGroup;
                projectTaskDTO.ExpectedStartDate = d.ExpectedStartDate;
                projectTaskDTO.ExpectedEndDate = d.ExpectedEndDate;
                projectTaskDTO.ExpectedTimeInHours = d.ExpectedTimeInHours;
                projectTaskDTO.Progress = d.Progress;
            

            }

            ViewBag.Projects = from u in projects
                               select new
                               {
                                   u.ProjectId,
                                   u.ProjectName
                               };

            return View("~/Plugins/Project.Management/Views/Task/TaskCreate.cshtml", projectTaskDTO);

        }
        [HttpPost]
        public IActionResult TaskCreate(ProjectTaskDTO projectTaskDTO)
        {
			Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            projectTaskDTO.CreatedBy = UserId;
			Int64 EmployeeId = _empolyeeService.GetEmployeeDetailsByUserId(UserId).EmployeeId;
            projectTaskDTO.AssignedBy = EmployeeId;


			if (ModelState.IsValid)
            {
                if (projectTaskDTO.ProjectTaskId == null)
                {
                    var a = _projectTaskService.ProjectTaskCreate(projectTaskDTO);
                    if (a == MennsageEnum.Success)
                    {
                        return Redirect("/Projects/Task/TaskView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "Task Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _projectTaskService.ProjectTaskUpdate(projectTaskDTO);
                    if (a == MennsageEnum.Updated)
                    {
                        return Redirect("/Projects/Task/TaskView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "Task Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            ViewBag.Projects = _projectService.GetProjects();


			return View("~/Plugins/Project.Management/Views/Task/TaskCreate.cshtml", projectTaskDTO);
        }

        [HttpGet]
        public IActionResult TaskList()
        {

            return View();
        }
       
        public JsonResult GroupProjectTaskByProjectId(int ProjectId)
        {
            return Json(_projectTaskService.GroupProjectTaskByProjectId(ProjectId));
        }

		public JsonResult NotCanceledTasksByProjectId(int ProjectId)
		{
            var a = _projectTaskService.NotCanceledTasksByProjectId(ProjectId);

			return Json(a);
		}

		public IActionResult TaskComplitedByOthersReport()
		{
			Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			Int64 EmployeeId = _empolyeeService.GetEmployeeDetailsByUserId(UserId).EmployeeId;
			var projecTasks = _projectTaskService.GetTaskComplitedByOthersReport(EmployeeId, UserId);
			var data = from u in projecTasks
					   select new
					   {
						   ProjectCode = u.Project.ProjectCode,
						   ProjectName = u.Project.ProjectName,
						   ComplitedHour = u.ComplitedOn - u.ExpectedStartDate,
						   TaskName = u.TaskName,
						   AssignedTo = u.AssignedTo.FullName,
						   TaskComplitedByOthersReasonByAssign = u.TaskComplitedByOthersReasonByAssign,
						   ComplitedBy = u.Employee.FullName,
						   TaskComplitedByOthersReasonByComplitedBy = u.TaskComplitedByOthersReasonByComplitedBy,

					   };
            ViewBag.tasks = data;
			return View("~/Plugins/Project.Management/Views/Task/TaskComplitedByOthersReport.cshtml");
		}

	}


}
