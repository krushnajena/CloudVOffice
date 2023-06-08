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
	public class ProjectActivityTypeController : BasePluginController
	{
		private readonly IProjectActivityTypeService _projectActivityTypeService;
		private readonly ITimesheetActivityCategoryService _timesheetActivityCategoryService;
		public ProjectActivityTypeController(IProjectActivityTypeService projectActivityTypeService,
            ITimesheetActivityCategoryService timesheetActivityCategoryService
            )
		{

			_projectActivityTypeService = projectActivityTypeService;
            _timesheetActivityCategoryService = timesheetActivityCategoryService;

        }
		[HttpGet]
		public IActionResult ProjectActivityTypeCreate(int? projectActivityTypeId)
		{
			ProjectActivityTypeDTO projectActivityTypeDTO = new ProjectActivityTypeDTO();
			ViewBag.ActivityCategory = _timesheetActivityCategoryService.GetTimesheetActivityCategories();

            if (projectActivityTypeId != null)
			{

				ProjectActivityType d = _projectActivityTypeService.GetProjectActivityTypeByProjectActivityTypeId(int.Parse(projectActivityTypeId.ToString()));

				projectActivityTypeDTO.ProjectActivityName = d.ProjectActivityName;
				projectActivityTypeDTO.ActivityCategory = d.ActivityCategoryId;

			}

			return View("~/Plugins/Project.Management/Views/ProjectActivityType/ProjectActivityTypeCreate.cshtml", projectActivityTypeDTO);

		}
		[HttpPost]
		public IActionResult ProjectActivityTypeCreate(ProjectActivityTypeDTO projectActivityTypeDTO)
		{
			projectActivityTypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (projectActivityTypeDTO.ProjectActivityTypeId == null)
				{
					var a = _projectActivityTypeService.ProjectActivityTypeCreate(projectActivityTypeDTO);
					if (a == MessageEnum.Success)
					{
						return Redirect("/Projects/ProjectActivityType/ProjectActivityTypeView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						ModelState.AddModelError("", "ProjectActivityType Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _projectActivityTypeService.ProjectActivityTypeUpdate(projectActivityTypeDTO);
					if (a == MessageEnum.Updated)
					{
						return Redirect("/Projects/ProjectActivityType/ProjectActivityTypeView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						ModelState.AddModelError("", "ProjectActivityType Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			ViewBag.ActivityCategory = _timesheetActivityCategoryService.GetTimesheetActivityCategories();
			return View("~/Plugins/Project.Management/Views/ProjectActivityType/ProjectActivityTypeCreate.cshtml", projectActivityTypeDTO);
		}
		public IActionResult ProjectActivityTypeView()
		{
			ViewBag.projectActivityTypes = _projectActivityTypeService.GetProjectActivityTypes();

			return View("~/Plugins/Project.Management/Views/ProjectActivityType/ProjectActivityTypeView.cshtml");
		}

		[HttpGet]
		public IActionResult ProjectActivityTypeDelete(Int64 projectActivityTypeId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _projectActivityTypeService.ProjectActivityTypeDelete(projectActivityTypeId, DeletedBy);
			return Redirect("/Projects/ProjectActivityType/ProjectActivityTypeView");
		}

		public JsonResult GetProjectActivityTypesByActivityCategory(int ActivityCategory)
		{
			return Json(_projectActivityTypeService.GetProjectActivityTypesByActivityCategory(ActivityCategory));
		}
	}

}




