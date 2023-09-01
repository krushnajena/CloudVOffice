using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Emp;
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
	public class InterviewPanelMemberController : BasePluginController
	{
		private readonly IInterviewPanelMemberService _interviewPanelMemberService;
		private readonly IInterviewRoundService _interviewRoundService;
		private readonly IEmployeeService _employeeService;

		public InterviewPanelMemberController(IInterviewPanelMemberService interviewPanelMemberService, IInterviewRoundService interviewRoundService, IEmployeeService employeeService)
		{
			_interviewPanelMemberService = interviewPanelMemberService;
			_interviewRoundService = interviewRoundService;
			_employeeService = employeeService;
		}


		[HttpGet]
		public IActionResult InterviewPanelMemberCreate(int? interviewPanelMemberId)
		{
			InterviewPanelMemberDTO interviewPanelMemberDTO = new InterviewPanelMemberDTO();

			var interviewRound = _interviewRoundService.GetInterviewRoundsList();
			ViewBag.InterviewRound = interviewRound;

			var employee = _employeeService.GetEmployees();
			ViewBag.Employee = employee;


			if (interviewPanelMemberId != null)
			{

				var d = _interviewPanelMemberService.GetInterviewPanelMemberById(int.Parse(interviewPanelMemberId.ToString()));

				interviewPanelMemberDTO.InterviewRoundId = d.InterviewRoundId;
				interviewPanelMemberDTO.EmployeeId = d.EmployeeId;

			}

			return View("~/Plugins/HR.Recruitment/Views/InterviewPanelMember/InterviewPanelMemberCreate.cshtml", interviewPanelMemberDTO);

		}

		[HttpPost]
		public IActionResult InterviewPanelMemberCreate(InterviewPanelMemberDTO interviewPanelMemberDTO)
		{
			interviewPanelMemberDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (interviewPanelMemberDTO.InterviewPanelMemberId == null)
				{
					var a = _interviewPanelMemberService.InterviewPanelMemberCreate(interviewPanelMemberDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("~/Recruitment/InterviewPanelMember/InterviewPanelMemberView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "InterviewPanelMember Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _interviewPanelMemberService.InterviewPanelMemberUpdate(interviewPanelMemberDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/InterviewPanelMember/InterviewPanelMemberView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "InterviewPanelMember Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			var interviewRound = _interviewRoundService.GetInterviewRoundsList();
			ViewBag.InterviewRound = interviewRound;

			var employee = _employeeService.GetEmployees();
			ViewBag.Employee = employee;

			return View("~/Plugins/HR.Recruitment/Views/InterviewPanelMember/InterviewPanelMemberCreate.cshtml", interviewPanelMemberDTO);
		}

		public IActionResult InterviewPanelMemberView()
		{
			ViewBag.interviewPanelMember = _interviewPanelMemberService.GetInterviewPanelMemberList();

			return View("~/Plugins/HR.Recruitment/Views/InterviewPanelMember/InterviewPanelMemberView.cshtml");
		}



		[HttpGet]
		public IActionResult InterviewPanelMemberDelete(int interviewPanelMemberId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _interviewPanelMemberService.InterviewPanelMemberDelete(interviewPanelMemberId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/InterviewPanelMember/InterviewPanelMemberView");
		}
	}
}
