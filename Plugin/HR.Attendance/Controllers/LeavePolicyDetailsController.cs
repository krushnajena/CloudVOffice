using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
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
	public class LeavePolicyDetailsController : BasePluginController
	{
		private readonly ILeavePolicyDetailsService _leavePolicyDetailsService;
		
		public LeavePolicyDetailsController(ILeavePolicyDetailsService leavePolicyDetailsService)
		{

			_leavePolicyDetailsService = leavePolicyDetailsService;
			
		}
		[HttpGet]
		public IActionResult LeavePolicyDetailsCreate(int? leavePolicyDetailsId)
		{
			LeavePolicyDetailsDTO leavePolicyDetailsDTO = new LeavePolicyDetailsDTO();
			if(leavePolicyDetailsId != null)
			{
				LeavePolicyDetails d = _leavePolicyDetailsService.GetLeavePolicyDetailsById(int.Parse(leavePolicyDetailsId.ToString()));
				leavePolicyDetailsDTO.LeavePolicyId = d.LeavePolicyId;
				leavePolicyDetailsDTO.LeaveTypeId = d.LeaveTypeId;
				leavePolicyDetailsDTO.NoOfLeaves = d.NoOfLeaves;
				leavePolicyDetailsDTO.AllocationMode = d.AllocationMode;
			}
			return View("~/Plugins/HR.Attendance/Views/LeavePolicyDetails/LeavePolicyDetailsCreate.cshtml", leavePolicyDetailsDTO);
		}
		[HttpPost]

		public IActionResult LeavePolicyDetailsCreate(LeavePolicyDetailsDTO leavePolicyDetailsDTO)
		{
			leavePolicyDetailsDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			

			if (ModelState.IsValid)
			{
				if (leavePolicyDetailsDTO.LeavePolicyDetailsId == null)
				{
					var a = _leavePolicyDetailsService.LeavePolicyDetailsCreate(leavePolicyDetailsDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Attendance/LeavePolicyDetails/LeavePolicyDetailsView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "LeavePolicyDetails Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _leavePolicyDetailsService.LeavePolicyDetailsUpdate(leavePolicyDetailsDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Attendance/LeavePolicyDetails/LeavePolicyDetailsView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "LeavePolicyDetails Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			

			return View("~/Plugins/HR.Attendance/Views/LeavePolicyDetails/LeavePolicyDetailsCreate.cshtml", leavePolicyDetailsDTO);

		}
	}
}
