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
		public ProjectActivityTypeController(IProjectActivityTypeService projectActivityTypeService)
		{

			_projectActivityTypeService = projectActivityTypeService;
		}
		[HttpGet]
		public IActionResult ProjectActivityTypeCreate(int? projectActivityTypeId)
		{
			ProjectActivityTypeDTO projectActivityTypeDTO = new ProjectActivityTypeDTO();

			if (projectActivityTypeId != null)
			{

				ProjectActivityType d = _projectActivityTypeService.GetProjectActivityTypeByProjectActivityTypeId(int.Parse(projectActivityTypeId.ToString()));

				projectActivityTypeDTO.ProjectActivityName = d.ProjectActivityName;

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
					if (a == MennsageEnum.Success)
					{
						return Redirect("/Projects/ProjectActivityType/ProjectActivityTypeView");
					}
					else if (a == MennsageEnum.Duplicate)
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
					if (a == MennsageEnum.Updated)
					{
						return Redirect("/Projects/ProjectActivityType/ProjectActivityTypeView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "ProjectActivityType Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}


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
	}

}




