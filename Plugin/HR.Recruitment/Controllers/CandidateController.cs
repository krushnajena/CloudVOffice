using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Recruitment.JO;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Data.DTO.Recruitment;
using Microsoft.AspNetCore.Mvc;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using CloudVOffice.Web.Framework;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class CandidateController : BasePluginController
	{
		private readonly ICandidateService _candidateService;
		private readonly IJobApplicationSourceService _jobApplicationSourceService;
		private readonly IWebHostEnvironment _hostingEnvironment;
		public CandidateController(ICandidateService candidateService, IJobApplicationSourceService jobApplicationSourceService, IWebHostEnvironment hostingEnvironment)
		{
			_candidateService = candidateService;
			_jobApplicationSourceService = jobApplicationSourceService;
			_hostingEnvironment = hostingEnvironment;
		}
		public IActionResult CandidateCreate(int? candidateId)
		{
			var jobApplicationSource = _jobApplicationSourceService.GetJobApplicationSourceList();
			ViewBag.JobApplicationSource = jobApplicationSource;

			CandidateDTO candidateDTO = new CandidateDTO();
			if (candidateId != null)
			{
				
				var d = _candidateService.GetCandidateById(int.Parse(candidateId.ToString()));
				candidateDTO.FirstName = d.FirstName;
				candidateDTO.MiddleName = d.MiddleName;
				candidateDTO.LastName = d.LastName;
				candidateDTO.Email = d.Email;
				candidateDTO.MobileNo = d.MobileNo;
				candidateDTO.StreetAddress = d.StreetAddress;
				candidateDTO.City = d.City;
				candidateDTO.ExperienceinYears = d.ExperienceinYears;
				candidateDTO.HighestQualification = d.HighestQualification;
				candidateDTO.CurrentJob = d.CurrentJob;
				candidateDTO.CurrentEmployer = d.CurrentEmployer;
				candidateDTO.ExpectedSalary = d.ExpectedSalary;
				candidateDTO.CurrentSalary = d.CurrentSalary;
				candidateDTO.Cv = d.Cv;
				candidateDTO.ApplicationSourceId = d.ApplicationSourceId;




			}

			return View("~/Plugins/HR.Recruitment/Views/Candidate/CandidateCreate.cshtml", candidateDTO);

		}
		[HttpPost]
		public IActionResult CandidateCreate(CandidateDTO candidateDTO)
		{
			candidateDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (candidateDTO.CVDOC != null)
				{
					FileInfo fileInfo = new FileInfo(candidateDTO.CVDOC.FileName);
					string extn = fileInfo.Extension.ToLower();
					Guid id = Guid.NewGuid();
					string filename = id.ToString() + extn;

					string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/Candidate");
					if (!Directory.Exists(uploadsFolder))
					{
						Directory.CreateDirectory(uploadsFolder);
					}
					string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
					string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
					candidateDTO.CVDOC.CopyTo(new FileStream(imagePath, FileMode.Create));
					candidateDTO.Cv = uniqueFileName;
				}
				if (candidateDTO.CandidateId == null)
				{
					var a = _candidateService.CandidateCreate(candidateDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("~/Recruitment/Candidate/CandidateView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "Candidate Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _candidateService.CandidateUpdate(candidateDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/Candidate/CandidateView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "Candidate Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			var jobApplicationSource = _jobApplicationSourceService.GetJobApplicationSourceList();
			ViewBag.JobApplicationSource = jobApplicationSource;



			return View("~/Plugins/HR.Recruitment/Views/Candidate/CandidateCreate.cshtml", candidateDTO);
		}
		public IActionResult CandidateView()
		{
			ViewBag.Candidate = _candidateService.GetCandidateList();

			return View("~/Plugins/HR.Recruitment/Views/Candidate/CandidateView.cshtml");
		}
		[HttpGet]
		public IActionResult CandidateDelete(int candidateId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _candidateService.CandidateDelete(candidateId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/Candidate/CandidateView");
		}
	}
}
