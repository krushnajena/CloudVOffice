using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
	public class SkillSetController : BasePluginController
	{
		private readonly ISkillSetService _skillSetService;
		public SkillSetController(ISkillSetService skillSetService)
		{

			_skillSetService = skillSetService;
		}
		[HttpGet]

		public IActionResult CreateSkillSet(int? skillSetId)
		{
			SkillSetDTO skillSetDTO = new SkillSetDTO();
			if (skillSetId != null)
			{

				var d = _skillSetService.GetSkillSetById(int.Parse(skillSetId.ToString()));

				
				skillSetDTO.SkillName = d.SkillName;
				skillSetDTO.SkillDescription = d.SkillDescription;
				

			}

			return View("~/Plugins/HR.Recruitment/Views/SkillSet/CreateSkillSet.cshtml", skillSetDTO);


		}
		[HttpPost]
		public IActionResult CreateSkillSet(SkillSetDTO skillSetDTO)
		{
			skillSetDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (skillSetDTO.SkillSetId == null)
				{
					var a = _skillSetService.CreateSkillSet(skillSetDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("~/Recruitment/SkillSet/SkillSetView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "SkillSet Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _skillSetService.SkillSetUpdate(skillSetDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/SkillSet/SkillSetView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "SkillSetView Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			return View("~/Plugins/HR.Recruitment/Views/SkillSet/CreateSkillSet.cshtml", skillSetDTO);
		}
		public IActionResult SkillSetView()
		{
			ViewBag.skillSet = _skillSetService.GetSkillSetList();

			return View("~/Plugins/HR.Recruitment/Views/SkillSet/SkillSetView.cshtml");
		}

		[HttpGet]
		public IActionResult SkillSeteDelete(int skillSetId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _skillSetService.SkillSeteDelete(skillSetId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/SkillSet/SkillSetView");
		}


	}
}
