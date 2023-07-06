using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers
{
	[Area(AreaNames.Attendance)]
	public class HolidayDaysController : BasePluginController
	{
		private readonly IHolidayDaysService _holidayDaysService;
		private readonly IHolidayService _holidayService;

		public HolidayDaysController(IHolidayDaysService holidayDaysService, IHolidayService holidayService)
		{
			_holidayDaysService = holidayDaysService;
			_holidayService = holidayService;


		}

		[HttpGet]
		public IActionResult CreateHolidayDays(int? HolidayDaysId)
		{
			HolidayDaysDTO holidayDaysDTO = new HolidayDaysDTO();

			var holiday = _holidayService.GetHolidayList();
			ViewBag.Holiday = holiday;


			if (HolidayDaysId != null)
			{

				var d = _holidayDaysService.GetHolidayDaysById(int.Parse(HolidayDaysId.ToString()));

				holidayDaysDTO.HolidayId = d.HolidayId;
				holidayDaysDTO.ForDate = d.ForDate;
				holidayDaysDTO.Description = d.Description;
			}

			return View("~/Plugins/HR.Attendance/Views/HolidayDay/CreateHolidayDays.cshtml", holidayDaysDTO);
		}

		[HttpPost]
		public IActionResult CreateHolidayDays(HolidayDaysDTO holidayDaysDTO)
		{
			holidayDaysDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (holidayDaysDTO.HolidayDaysId == null)
				{
					var a = _holidayDaysService.CreateHolidayDays(holidayDaysDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Attendance/HolidayDays/HolidayDaysView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "HolidayDay Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _holidayDaysService.HolidayDaysUpdate(holidayDaysDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Attendance/HolidayDays/HolidayDaysView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "HolidayDay Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			var holiday = _holidayService.GetHolidayList();
			ViewBag.Holiday = holiday;

			return View("~/Plugins/HR.Attendance/Views/HolidayDay/CreateHolidayDays.cshtml", holidayDaysDTO);
		}

		[Authorize(Roles = "HR Manager")]
		public IActionResult HolidayDaysView()
		{
			ViewBag.HolidayDays = _holidayDaysService.GetHolidayDaysList();

			return View("~/Plugins/HR.Attendance/Views/HolidayDay/HolidayDaysView.cshtml");
		}

		[HttpGet]
		public IActionResult HolidayDaysDelete(Int64 HolidayDaysId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _holidayDaysService.HolidayDaysDelete(HolidayDaysId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Attendance/HolidayDays/HolidayDaysView");
		}
	}
}
