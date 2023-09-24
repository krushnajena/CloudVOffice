using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Services.Recruitment.JO;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
	public class JobApplicationController:BasePluginController
	{
		private readonly IJobApplicationService _jobApplicationService;
		private readonly IJobApplicationSourceService _jobApplicationSourceService;
		private readonly IJobOpeningService _jobOpeningService;
		private readonly IWebHostEnvironment _hostingEnvironment;
		public JobApplicationController(IJobApplicationService jobApplicationService, IJobApplicationSourceService jobApplicationSourceService , IJobOpeningService jobOpeningService, IWebHostEnvironment hostingEnvironment)
		{

			_jobApplicationService = jobApplicationService;
			_jobApplicationSourceService = jobApplicationSourceService;
			_jobOpeningService = jobOpeningService;
			_hostingEnvironment = hostingEnvironment;
		}
		[HttpGet]
		public IActionResult CreateJobApplication(int? jobApplicationId)
		{
			JobApplicationDTO jobApplicationDTO = new JobApplicationDTO();

			var jobApplicationSource = _jobApplicationSourceService.GetJobApplicationSourceList();
			ViewBag.JobApplicationSource = jobApplicationSource;
			var jobOpening = _jobOpeningService.GetJobOpeningsList();
			ViewBag.JobOpening = jobOpening;

			if (jobApplicationId != null)
			{

				var d = _jobApplicationService.GetJobApplicationById(int.Parse(jobApplicationId.ToString()));

				jobApplicationDTO.JobId = d.JobId;
				jobApplicationDTO.ApplicantName = d.ApplicantName;
				jobApplicationDTO.EmailAddress = d.EmailAddress;
				jobApplicationDTO.PhoneNo = d.PhoneNo;
				jobApplicationDTO.JobApplicationSourceId = d.JobApplicationSourceId;
				jobApplicationDTO.TagDescription = d.TagDescription;
				jobApplicationDTO.CV = d.CV;
				jobApplicationDTO.SalaryExpectation = d.SalaryExpectation;
				jobApplicationDTO.SalaryExpectationLowerRange = d.SalaryExpectationLowerRange;

			}

			return View("~/Plugins/HR.Recruitment/Views/JobApplication/CreateJobApplication.cshtml", jobApplicationDTO);


		}

		[HttpPost]
		public IActionResult CreateJobApplication(JobApplicationDTO jobApplicationDTO)
		{
			jobApplicationDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (jobApplicationDTO.CVDOC != null)
				{
					FileInfo fileInfo = new FileInfo(jobApplicationDTO.CVDOC.FileName);
					string extn = fileInfo.Extension.ToLower();
					Guid id = Guid.NewGuid();
					string filename = id.ToString() + extn;

					string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/JobApplication");
					if (!Directory.Exists(uploadsFolder))
					{
						Directory.CreateDirectory(uploadsFolder);
					}
					string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
					string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
					jobApplicationDTO.CVDOC.CopyTo(new FileStream(imagePath, FileMode.Create));
					jobApplicationDTO.CV = uniqueFileName;
				}
				if (jobApplicationDTO.JobApplicationId == null)
				{
					var a = _jobApplicationService.JobApplicationCreate(jobApplicationDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("~/Recruitment/JobApplication/JobApplicationView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "JobApplication Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _jobApplicationService.JobApplicationUpdate(jobApplicationDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/JobApplication/JobApplicationView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "JobApplication Already Exists");
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
			var jobOpening = _jobOpeningService.GetJobOpeningsList();
			ViewBag.JobOpening = jobOpening;
			return View("~/Plugins/HR.Recruitment/Views/JobApplication/CreateJobApplication.cshtml", jobApplicationDTO);
		}

		
		public IActionResult JobApplicationView()
		{
			ViewBag.jobApplication = _jobApplicationService.GetJobApplicationList();

			return View("~/Plugins/HR.Recruitment/Views/JobApplication/JobApplicationView.cshtml");
		}

		[HttpGet]
		public IActionResult DeleteJobApplication(int jobApplicationId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _jobApplicationService.JobApplicationDelete(jobApplicationId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/JobApplication/JobApplicationView");
		}

		public JsonResult GetJobApplicationsByJobId(int JobId)
		{
			return Json(_jobApplicationService.GetJobApplicationsByJobId(JobId));
		}
	}
}
