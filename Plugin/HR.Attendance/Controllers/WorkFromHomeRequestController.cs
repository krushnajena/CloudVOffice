using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class WorkFromHomeRequestController : BasePluginController
    {
        private readonly IWorkFromHomeRequestService _workFromHomeRequestService;
        public WorkFromHomeRequestController(IWorkFromHomeRequestService workFromHomeRequestService)
        {
            _workFromHomeRequestService = workFromHomeRequestService;
        }

        [HttpGet]
        public IActionResult WorkFromHomeRequestCreate(int? WorkFromHomeRequestId)
        {
            WorkFromHomeRequestDTO workFromHomeRequestDTO = new WorkFromHomeRequestDTO();
            if (WorkFromHomeRequestId != null)
            {

                var d = _workFromHomeRequestService.GetWorkFromHomeRequestById(int.Parse(WorkFromHomeRequestId.ToString()));

                workFromHomeRequestDTO.EmployeeId = d.EmployeeId;
                workFromHomeRequestDTO.FromDate = d.FromDate;
                workFromHomeRequestDTO.ToDate = d.ToDate;
                workFromHomeRequestDTO.Reason = d.Reason;
                workFromHomeRequestDTO.ApprovalStatus = d.ApprovalStatus;
                workFromHomeRequestDTO.ApprovedBy = d.ApprovedBy;
            }

            return View("~/Plugins/HR.Attendance/Views/WorkFromHomeRequest/WorkFromHomeRequestCreate.cshtml", workFromHomeRequestDTO);


        }

        [HttpPost]
        public IActionResult WorkFromHomeRequestCreate(WorkFromHomeRequestDTO workFromHomeRequestDTO)
        {
            workFromHomeRequestDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (workFromHomeRequestDTO.WorkFromHomeRequestId == null)
                {
                    var a = _workFromHomeRequestService.WorkFromHomeRequestCreate(workFromHomeRequestDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/WorkFromHomeRequest/WorkFromHomeRequestView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "WorkFromHomeRequest Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _workFromHomeRequestService.WorkFromHomeRequestUpdate(workFromHomeRequestDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/WorkFromHomeRequest/WorkFromHomeRequestView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "WorkFromHomeRequest Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Attendance/Views/WorkFromHomeRequest/WorkFromHomeRequestCreate.cshtml", workFromHomeRequestDTO);
        }

        public IActionResult WorkFromHomeRequestView()
        {
            ViewBag.workFromHomeRequest = _workFromHomeRequestService.GetWorkFromHomeRequestList();

            return View("~/Plugins/HR.Attendance/Views/WorkFromHomeRequest/WorkFromHomeRequestView.cshtml");
        }

        [HttpGet]
        public IActionResult WorkFromHomeRequestDelete(Int64 workFromHomeRequestId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _workFromHomeRequestService.WorkFromHomeRequestDelete(workFromHomeRequestId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/WorkFromHomeRequest/WorkFromHomeRequestView");
        }

    }
}
