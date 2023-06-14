using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;

using CloudVOffice.Services.Emp;
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
    public class TimesheetController : BasePluginController
    {
        private readonly ITimesheetService _timesheetService;
        private readonly IEmployeeService _employeeService;
        private readonly IProjectActivityTypeService _projectActivityTypeService;
        private readonly IProjectService _projectService;
        private readonly IProjectTaskService _projectTaskService;
        private readonly ITimesheetActivityCategoryService _timesheetActivityCategoryService;
        public TimesheetController(ITimesheetService timesheetService, IEmployeeService employeeService, IProjectActivityTypeService projectActivityTypeService, IProjectService projectService, IProjectTaskService projectTaskService,
			 ITimesheetActivityCategoryService timesheetActivityCategoryService)
        {

            _timesheetService = timesheetService;
            _employeeService = employeeService;
            _projectActivityTypeService = projectActivityTypeService;
            _projectService = projectService;
            _projectTaskService = projectTaskService;
			_timesheetActivityCategoryService = timesheetActivityCategoryService;

		}
        [HttpGet]
        public IActionResult TimesheetCreate(Int64? timesheetId)
        {
            TimesheetDTO timesheetDTO = new TimesheetDTO();
			ViewBag.ActivityCategory = _timesheetActivityCategoryService.GetTimesheetActivityCategories();
			if (timesheetId != null)
            {

                Timesheet d = _timesheetService.GetTimesheetByTimesheetId(Int64.Parse(timesheetId.ToString()));

                timesheetDTO.EmployeeId = d.EmployeeId;
                timesheetDTO.TimeSheetForDate = d.TimeSheetForDate;
                timesheetDTO.TimesheetActivityType = d.TimesheetActivityType;
                timesheetDTO.ActivityId = d.ActivityId;
                timesheetDTO.ProjectId = d.ProjectId;
                timesheetDTO.TaskId = d.TaskId;
                timesheetDTO.FromTime = d.FromTime;
                timesheetDTO.ToTime = d.ToTime;
                timesheetDTO.DurationInHours = d.DurationInHours;
                timesheetDTO.Description = d.Description;
                timesheetDTO.IsBillable = d.IsBillable;
                timesheetDTO.HourlyRate = d.HourlyRate;
                timesheetDTO.TimeSheetApprovalStatus = d.TimeSheetApprovalStatus;
                timesheetDTO.TimesheetApprovedBy = d.TimesheetApprovedBy;
                timesheetDTO.TimeSheetApprovedOn = d.TimeSheetApprovedOn;
                timesheetDTO.TimeSheetApprovalRemarks = d.TimeSheetApprovalRemarks;
            }


            return View("~/Plugins/Project.Management/Views/Timesheet/TimesheetCreate.cshtml", timesheetDTO);

        }



        [HttpPost]
        public IActionResult TimesheetCreate(TimesheetDTO timesheetDTO)
        {
            timesheetDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            timesheetDTO.EmployeeId = _employeeService.GetEmployeeDetailsByUserId(timesheetDTO.CreatedBy).EmployeeId;

            if (ModelState.IsValid)
            {
                if (timesheetDTO.TimesheetId == null)
                {
                    var a = _timesheetService.TimesheetCreate(timesheetDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Projects/Timesheet/TimesheetView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Timesheet Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _timesheetService.TimesheetUpdate(timesheetDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Projects/Timesheet/TimesheetView");
                    }
                   
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
			ViewBag.ActivityCategory = _timesheetActivityCategoryService.GetTimesheetActivityCategories();

			return View("~/Plugins/Project.Management/Views/Timesheet/TimesheetCreate.cshtml", timesheetDTO);
        }
        public IActionResult TimesheetView()
        {

           Int64 createdBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 employeeId = _employeeService.GetEmployeeDetailsByUserId(createdBy).EmployeeId;
           
            ViewBag.Timesheets = _timesheetService.GetMyTimeSheets(employeeId);

            return View("~/Plugins/Project.Management/Views/Timesheet/TimesheetView.cshtml");
        }

        [HttpGet]
        public IActionResult TimesheetDelete(Int64 timesheetId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _timesheetService.TimesheetDelete(timesheetId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Projects/Timesheet/TimesheetView");
        }

        public IActionResult TimeSheetsToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;

            }
            var timesheets = _timesheetService.GetTimeSheetsToValidate(EmployeeId);
            var data = from u in timesheets
                       select new
                       {
                           TimesheetId = u.TimesheetId,
                           Timesheetdate = u.CreatedDate,
                           EmployeeName = u.Employee.FullName,
                           ActvityCategory = u.TimesheetActivityCategory.TimesheetActivityCategoryName,
                           ActvityName = u.ProjectActivityType.ProjectActivityName,
                           Project = u.Project,
                           Task = u.ProjectTask,
                           DurationInHours = u.DurationInHours,
                           Description = u.Description,
                       };
            ViewBag.timeSheets = data;
            return View("~/Plugins/Project.Management/Views/Timesheet/TimeSheetsToValidate.cshtml");
        }

        public IActionResult ProjectWiseEffortHourReport()
        {
            return View();
        }
        public IActionResult TimesheetReport()
        {
            return View();
        }



	}
}
