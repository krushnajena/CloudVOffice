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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.Management.Controllers
{
	[Area(AreaNames.Projects)]
	public class TimesheetActivityCategoryController : BasePluginController
	{
		private readonly ITimesheetActivityCategoryService _timesheetActivityCategoryService;
		public TimesheetActivityCategoryController(ITimesheetActivityCategoryService timesheetActivityCategoryService)
		{
			_timesheetActivityCategoryService = timesheetActivityCategoryService;
		}

		public IActionResult TimesheetActivityCategoryCreate(int? TimesheetActivityCategoryId)
		{
			TimesheetActivityCategoryDTO timesheetActivityCategory = new TimesheetActivityCategoryDTO();
			if (TimesheetActivityCategoryId != null)
			{
				var a = _timesheetActivityCategoryService.GetTimesheetActivityCategoryByTimesheetActivityCategoryId(int.Parse(TimesheetActivityCategoryId.ToString()));
				timesheetActivityCategory.TimesheetActivityCategoryName = a.TimesheetActivityCategoryName;
			}
			return View("~/Plugins/Project.Management/Views/TimesheetActivityCategory/TimesheetActivityCategoryCreate.cshtml", timesheetActivityCategory);
		}
		[HttpPost]
		public IActionResult TimesheetActivityCategoryCreate(TimesheetActivityCategoryDTO timesheetActivityCategoryDTO)
		{
			timesheetActivityCategoryDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (timesheetActivityCategoryDTO.TimesheetActivityCategoryId == null)
				{
					var a = _timesheetActivityCategoryService.TimesheetActivityCategoryCreate(timesheetActivityCategoryDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Projects/TimesheetActivityCategory/TimesheetActivityCategoryView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "TimesheetActivityCategory Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _timesheetActivityCategoryService.TimesheetActivityCategoryUpdate(timesheetActivityCategoryDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Projects/TimesheetActivityCategory/TimesheetActivityCategoryView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "TimesheetActivityCategory Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			return View("~/Plugins/Project.Management/Views/TimesheetActivityCategory/TimesheetActivityCategoryCreate.cshtml", timesheetActivityCategoryDTO);
		}
		public IActionResult TimesheetActivityCategoryView()
		{
			ViewBag.timesheetActivityCategories = _timesheetActivityCategoryService.GetTimesheetActivityCategories();

			return View("~/Plugins/Project.Management/Views/TimesheetActivityCategory/TimesheetActivityCategoryView.cshtml");
		}

		[HttpGet]
		public IActionResult TimesheetActivityCategoryDelete(int timesheetActivityCategoryId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _timesheetActivityCategoryService.TimesheetActivityCategoryDelete(timesheetActivityCategoryId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Projects/TimesheetActivityCategory/TimesheetActivityCategoryView");
		}
	}
}
