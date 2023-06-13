using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Attendance.Controllers
{
	[Area(AreaNames.Attendance)]
	public class LeaveTypeController : BasePluginController
    {
        private readonly ILeaveTypeService _leaveTypeService;
        public LeaveTypeController(ILeaveTypeService leaveTypeService)
        {

            _leaveTypeService = leaveTypeService;
        }

        [HttpGet]
        public IActionResult LeaveTypeCreate(int? LeaveTypeId)
        {
            LeaveTypeDTO leaveTypeDTO = new LeaveTypeDTO();
            if (LeaveTypeId != null)
            {

                var d = _leaveTypeService.GetLeaveTypeById(int.Parse(LeaveTypeId.ToString()));

                leaveTypeDTO.LeaveTypeName = d.LeaveTypeName;
                leaveTypeDTO.MaximumLeaveAllocationAllowed = d.MaximumLeaveAllocationAllowed;
                leaveTypeDTO.ApplicableAfterWorkingDays = d.ApplicableAfterWorkingDays;
                leaveTypeDTO.MaximumConsecutiveLeavesAllowed = d.MaximumConsecutiveLeavesAllowed;
                leaveTypeDTO.IsCarryForward = d.IsCarryForward;
                leaveTypeDTO.MaximumCarryForwardedLeaves = d.MaximumCarryForwardedLeaves;
                leaveTypeDTO.ExpireCarryForwardedLeaves = d.ExpireCarryForwardedLeaves;
                leaveTypeDTO.IsLeaveWithoutPay = d.IsLeaveWithoutPay;
                leaveTypeDTO.IsPartiallyPaidLeave = d.IsPartiallyPaidLeave;
                leaveTypeDTO.IsOptionalLeave = d.IsOptionalLeave;
                leaveTypeDTO.AllowNegativeBalance = d.AllowNegativeBalance;
                leaveTypeDTO.AllowOverAllocation = d.AllowOverAllocation;
                leaveTypeDTO.IsCompensatory = d.IsCompensatory;
                leaveTypeDTO.AllowEncashment = d.AllowEncashment;
                leaveTypeDTO.EncashmentThresholdDays = d.EncashmentThresholdDays;
                leaveTypeDTO.EarningSalaryComponentId = d.EarningSalaryComponentId;
                leaveTypeDTO.IsEarnedLeave = d.IsEarnedLeave;
                leaveTypeDTO.EarnedLeaveFrequency = d.EarnedLeaveFrequency;
                leaveTypeDTO.BasedOnDateOfJoining = d.BasedOnDateOfJoining;
                leaveTypeDTO.Rounding = d.Rounding;
            }

            return View("~/Plugins/HR.Attendance/Views/LeaveType/LeaveTypeCreate.cshtml", leaveTypeDTO);


        }

        [HttpPost]
        public IActionResult LeaveTypeCreate(LeaveTypeDTO leaveTypeDTO)
        {
            leaveTypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (leaveTypeDTO.LeaveTypeId == null)
                {
                    var a = _leaveTypeService.LeaveTypeCreate(leaveTypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/LeaveType/LeaveTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "LeaveType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _leaveTypeService.LeaveTypeUpdate(leaveTypeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/LeaveType/LeaveTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "LeaveType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Attendance/Views/LeaveType/LeaveTypeCreate.cshtml", leaveTypeDTO);
        }

        [Authorize(Roles = "HR Manager")]
        public IActionResult LeaveTypeView()
        {
            ViewBag.leaveType = _leaveTypeService.GetLeaveTypeList();

            return View("~/Plugins/HR.Attendance/Views/LeaveType/LeaveTypeView.cshtml");
        }

        [HttpGet]
        public IActionResult DeleteLeaveType(int LeaveTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _leaveTypeService.LeaveTypeDelete(LeaveTypeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/LeaveType/LeaveTypeView");
        }
    }
}
