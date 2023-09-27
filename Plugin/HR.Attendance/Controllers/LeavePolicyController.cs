using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HR.Attendance.Controllers
{
	[Area(AreaNames.Attendance)]
	public class LeavePolicyController : BasePluginController
	{

		private readonly ILeavePolicyService _leavePolicyService;
		private readonly ILeaveTypeService _leaveTypeService;
		private readonly IEmployeeGradeServices _employeeGradeServices;
		private readonly ILeavePeriodService _leavePeriodService;
	
		public LeavePolicyController(ILeavePolicyService leavePolicyService, ILeaveTypeService leaveTypeService, IEmployeeGradeServices employeeGradeServices, ILeavePeriodService leavePeriodService)
		{


			_leavePolicyService = leavePolicyService;
			_leaveTypeService = leaveTypeService;
			_employeeGradeServices = employeeGradeServices;
			_leavePeriodService = leavePeriodService;
			
		}
		[HttpGet]
		public IActionResult LeavePolicyCreate(int? leavePolicyId)
		{
			LeavePolicyDTO leavePolicyDTO = new LeavePolicyDTO();
			if (leavePolicyId != null)
			{
				var leavePolicyDetails = _leavePolicyService.GetLeavePolicyByLeavePolicyId(int.Parse(leavePolicyId.ToString()));
                leavePolicyDTO.LeavePeriodId = leavePolicyDetails.LeavePeriodId;
                leavePolicyDTO.EmployeeGradeId = leavePolicyDetails.EmployeeGradeId;
                leavePolicyDTO.LeavePolicyDetails = new List<LeavePolicyDetailsDTO>();
				var pd = leavePolicyDetails.LeavePolicyDetails.ToList();

                for (int i = 0; i < leavePolicyDetails.LeavePolicyDetails.Count; i++)
				{
					leavePolicyDTO.LeavePolicyDetails.Add(new LeavePolicyDetailsDTO
					{

						LeavePolicyId = pd[i].LeavePolicyId,
                        LeaveTypeId = pd[i].LeaveTypeId,
						NoOfLeaves = pd[i].NoOfLeaves,
						LeaveTypeName = pd[i].LeaveType.LeaveTypeName,
						AllocationMode = pd[i].AllocationMode,
                        LeaveAllocationMode = pd[i].AllocationMode==1?"Annual":"Monthly"
                    });
				}
				leavePolicyDTO.LeavePolicyDetailsString = JsonConvert.SerializeObject(leavePolicyDTO.LeavePolicyDetailsString);
			}
			else
			{
				leavePolicyDTO.LeavePolicyDetails = new List<LeavePolicyDetailsDTO>();
			}
			
			var leavePeriod = _leavePeriodService.GetLeavePeriodList();
			List<object> AllocationMode = new List<object>();
			AllocationMode.Add(new
			{
				Text = "Annual",
				Value = 1
			});
			AllocationMode.Add(new
			{
				Text = "Monthly",
				Value = 2
			});
			ViewBag.LeavePeriods = leavePeriod;
			ViewBag.LeaveAllocationMode = AllocationMode;
			ViewBag.employeeGrades = _employeeGradeServices.GetEmployeeGradeList();
			ViewBag.LeaveTypes = _leaveTypeService.GetLeaveTypeList();

			return View("~/Plugins/HR.Attendance/Views/LeavePolicy/LeavePolicyCreate.cshtml", leavePolicyDTO);
		}
		[HttpPost]

		public IActionResult LeavePolicyCreate(LeavePolicyDTO leavePolicyDTO)
		{
			leavePolicyDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			if (leavePolicyDTO.LeavePolicyDetailsString != null && leavePolicyDTO.LeavePolicyDetailsString != "")
			{
				leavePolicyDTO.LeavePolicyDetails = JsonConvert.DeserializeObject<List<LeavePolicyDetailsDTO>>(leavePolicyDTO.LeavePolicyDetailsString);

			}

			if (ModelState.IsValid)
			{
				if (leavePolicyDTO.LeavePolicyId == null)
				{
					var a = _leavePolicyService.LeavePolicyCreate(leavePolicyDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Attendance/LeavePolicy/LeavePolicyReport");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "LeavePolicy Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _leavePolicyService.LeavePolicyUpdate(leavePolicyDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Attendance/LeavePolicy/LeavePolicyReport");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "LeavePolicy Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			var leavePeriod = _leavePeriodService.GetLeavePeriodList();
			ViewBag.LeavePeriods = leavePeriod;

			ViewBag.employeeGrades = _employeeGradeServices.GetEmployeeGradeList();


			return View("~/Plugins/HR.Attendance/Views/LeavePolicy/LeavePolicyCreate.cshtml", leavePolicyDTO);

		}
		public IActionResult LeavePolicyDelete(int leavePolicyId)
		{
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			var a = _leavePolicyService.LeavePolicyDelete(leavePolicyId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/LeavePolicy/LeavePolicyReport");
        }

        public IActionResult LeavePolicyReport()
        {
			ViewBag.report = _leavePolicyService.LeavePolicyReport();

			return View("~/Plugins/HR.Attendance/Views/LeavePolicy/LeavePolicyReport.cshtml");
		}

       



    }



}
