using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Services.Projects;
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

        public TaskController(IProjectTaskService projectTaskService)
        {

            _projectTaskService = projectTaskService;
        }
        public IActionResult Tasks(int ProjectId)
        {
            var a = _projectTaskService.ProjectTaskByProjectId(ProjectId);
            ViewBag.Tasks = a.AsEnumerable();
            return View("~/Plugins/Project.Management/Views/Task/Tasks.cshtml");
        }

        [HttpGet]
        public IActionResult ProjectTaskCreate(Int64 projectTaskId)
        {
            ProjectTaskDTO projectTaskDTO = new ProjectTaskDTO();

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
                projectTaskDTO.ComplitedBy = d.ComplitedBy;
                projectTaskDTO.ComplitedOn = d.ComplitedOn;
                projectTaskDTO.TotalHoursByTimeSheet = d.TotalHoursByTimeSheet;
                projectTaskDTO.TotalBillableHourByTimeSheet = d.TotalBillableHourByTimeSheet;

            }

            return View("~/Plugins/Project.Management/Views/ProjectTask/ProjectTaskCreate.cshtml", projectTaskDTO);

        }
        [HttpPost]
        public IActionResult ProjectTaskCreate(ProjectTaskDTO projectTaskDTO)
        {
            projectTaskDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (projectTaskDTO.ProjectTaskId == null)
                {
                    var a = _projectTaskService.ProjectTaskCreate(projectTaskDTO);
                    if (a == MennsageEnum.Success)
                    {
                        return Redirect("/Projects/ProjectTask/ProjectTaskView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "ProjectTask Already Exists");
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
                        return Redirect("/Projects/ProjectTask/ProjectTaskView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "ProjectTask Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }


            return View("~/Plugins/Project.Management/Views/ProjectTask/ProjectTaskCreate.cshtml", projectTaskDTO);
        }
        public IActionResult ProjectTypeView()
        {
            ViewBag.projecttypes = _projectTaskService.GetProjectTasks();

            return View("~/Plugins/Project.Management/Views/ProjectTask/ProjectTaskView.cshtml");
        }
        public IActionResult ProjectTypeDelete(Int64 projectTaskId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _projectTaskService.ProjectTaskDelete(projectTaskId, DeletedBy);
            return Redirect("/Projects/ProjectTask/ProjectTaskView");
        }
    }
}
