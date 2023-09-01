using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
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
	public class InterviewRoundController : BasePluginController
	{
		private readonly IInterviewRoundService _interviewRoundService;
		private readonly IInterviewTypeService _interviewTypeService;
		private readonly IDesignationService _designationService;

		public InterviewRoundController(IInterviewRoundService interviewRoundService, IInterviewTypeService interviewTypeService, IDesignationService designationService)
		{
			_interviewRoundService = interviewRoundService;
			_interviewTypeService = interviewTypeService;
			_designationService = designationService;
		}

		[HttpGet]
		public IActionResult InterviewRoundCreate(int? interviewRoundId)
		{
			InterviewRoundDTO interviewRoundDTO = new InterviewRoundDTO();

			var interviewType = _interviewTypeService.GetInterviewTypeList();
			ViewBag.InterviewType = interviewType;

			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;


			if (interviewRoundId != null)
			{

				var d = _interviewRoundService.GetInterviewRoundById(int.Parse(interviewRoundId.ToString()));

				interviewRoundDTO.InterviewRoundName = d.InterviewRoundName;
				interviewRoundDTO.InterviewTypeId = d.InterviewTypeId;
				interviewRoundDTO.DesignationId = d.DesignationId;
				interviewRoundDTO.InterviewRoundOrder = d.InterviewRoundOrder;

			}

			return View("~/Plugins/HR.Recruitment/Views/InterviewRound/InterviewRoundCreate.cshtml", interviewRoundDTO);

		}


		[HttpPost]
		public IActionResult InterviewRoundCreate(InterviewRoundDTO interviewRoundDTO)
		{
			interviewRoundDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (interviewRoundDTO.InterviewRoundId == null)
				{
					var a = _interviewRoundService.InterviewRoundCreate(interviewRoundDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("~/Recruitment/InterviewRound/InterviewRoundView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "InterviewRound Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _interviewRoundService.InterviewRoundUpdate(interviewRoundDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/InterviewRound/InterviewRoundView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "InterviewRound Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			var interviewType = _interviewTypeService.GetInterviewTypeList();
			ViewBag.InterviewType = interviewType;

			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;

			return View("~/Plugins/HR.Recruitment/Views/InterviewRound/InterviewRoundCreate.cshtml", interviewRoundDTO);
		}

		public IActionResult InterviewRoundView()
		{
			ViewBag.interviewRound = _interviewRoundService.GetInterviewRoundsList();

			return View("~/Plugins/HR.Recruitment/Views/InterviewRound/InterviewRoundView.cshtml");
		}



		[HttpGet]
		public IActionResult InterviewRoundDelete(int interviewRoundId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _interviewRoundService.InterviewRoundDelete(interviewRoundId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/InterviewRound/InterviewRoundView");
		}

	}
}
