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
    public class TaskAssignmentController : BasePluginController
    {
        private readonly ITaskAssignmentService _taskAssignmentService;
        public TaskAssignmentController(ITaskAssignmentService taskAssignmentService)
        {

            _taskAssignmentService = taskAssignmentService;
        }
        [HttpGet]
        public IActionResult TaskAssignmentCreate(Int64 taskAssignmentId)
        {
            TaskAssignmentDTO taskAssignmentDTO = new TaskAssignmentDTO();

            if (taskAssignmentId != null)
            {

                TaskAssignment d = _taskAssignmentService.GetTaskAssignmentByTaskAssignmentId(int.Parse(taskAssignmentId.ToString()));

                taskAssignmentDTO.TaskId = d.TaskId;
                taskAssignmentDTO.EmployeeId = d.EmployeeId;
                taskAssignmentDTO.AssignedBy = d.AssignedBy;
                taskAssignmentDTO.AssignedOn = d.AssignedOn;
                taskAssignmentDTO.CompliteBy = d.CompliteBy;
                taskAssignmentDTO.ActualCompliteOn = d.ActualCompliteOn;
                taskAssignmentDTO.DelayReason = d.DelayReason;
                taskAssignmentDTO.IsDelayApproved = d.IsDelayApproved;
                taskAssignmentDTO.DelayApprovedBy = d.DelayApprovedBy;
                taskAssignmentDTO.DelayApprovedOn = d.DelayApprovedOn;
                

            }

            return View("~/Plugins/Project.Management/Views/TaskAssignment/TaskAssignmentCreate.cshtml", taskAssignmentDTO);

        }
        [HttpPost]
        public IActionResult TaskAssignmentCreate(TaskAssignmentDTO taskAssignmentDTO)
        {
            taskAssignmentDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (taskAssignmentDTO.TaskAssignmentId == null)
                {
                    var a = _taskAssignmentService.TaskAssignmentCreate(taskAssignmentDTO);
                    if (a == MennsageEnum.Success)
                    {
                        return Redirect("/Projects/TaskAssignment/TaskAssignmentView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "TaskAssignment Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _taskAssignmentService.TaskAssignmentUpdate(taskAssignmentDTO);
                    if (a == MennsageEnum.Updated)
                    {
                        return Redirect("/Projects/TaskAssignment/TaskAssignmentView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "TaskAssignment Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }


            return View("~/Plugins/Project.Management/Views/TaskAssignment/TaskAssignmentCreate.cshtml", taskAssignmentDTO);
        }
        public IActionResult TaskAssignmentView()
        {
            ViewBag.TaskAssignments = _taskAssignmentService.GetTaskAssignments();

            return View("~/Plugins/Project.Management/Views/TaskAssignment/TaskAssignmentView.cshtml");
        }
        public IActionResult TaskAssignmentDelete(Int64 taskAssignmentId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _taskAssignmentService.TaskAssignmentDelete(taskAssignmentId, DeletedBy);
            return Redirect("/Projects/TaskAssignment/TaskAssignmentView");
        }
    }
}
