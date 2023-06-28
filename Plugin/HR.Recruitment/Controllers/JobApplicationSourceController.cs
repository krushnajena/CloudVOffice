using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;
using CloudVOffice.Core.Domain.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Services.Accounts;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework.Controllers;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using Microsoft.AspNetCore.Authorization;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class JobApplicationSourceController : BasePluginController
    {
        private readonly IJobApplicationSourceService _jobApplicationSourceService;
        public JobApplicationSourceController(IJobApplicationSourceService jobApplicationSourceService)
        {

            _jobApplicationSourceService = jobApplicationSourceService;
        }
        [HttpGet]
        public IActionResult JobApplicationSourceCreate(int? JobApplicationSourceId)
        {
            JobApplicationSourceDTO JobApplicationSourceDTO = new JobApplicationSourceDTO();

            if (JobApplicationSourceId != null)
            {

                var d = _jobApplicationSourceService.GetJobApplicationSourceByJobApplicationSourceId(int.Parse(JobApplicationSourceId.ToString()));

                JobApplicationSourceDTO.SourceName = d.SourceName;

            }

            return View("~/Plugins/HR.Recruitment/Views/JobApplicationSource/JobApplicationSourceCreate.cshtml", JobApplicationSourceDTO);

        }
        [HttpPost]
        public IActionResult JobApplicationSourceCreate(JobApplicationSourceDTO jobApplicationSourceDTO)
        {
            jobApplicationSourceDTO.CreatedBy = (int)long.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (jobApplicationSourceDTO.JobApplicationSourceId == null)
                {
                    var a = _jobApplicationSourceService.JobApplicationSourceCreate(jobApplicationSourceDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/JobApplicationSource/JobApplicationSourceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "JobApplicationSource Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _jobApplicationSourceService.JobApplicationSourceUpdate(jobApplicationSourceDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/JobApplicationSource/JobApplicationSourceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "JobApplicationSource Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Recruitment/Views/JobApplicationSource/JobApplicationSourceCreate.cshtml", jobApplicationSourceDTO);
        }
        //[Authorize(Roles = "HR Manager")]
        public IActionResult JobApplicationSourceView()
        {
            ViewBag.jobApplicationSource = _jobApplicationSourceService.GetJobApplicationSourceList();

            return View("~/Plugins/HR.Recruitment/Views/JobApplicationSource/JobApplicationSourceView.cshtml");
        }
        [HttpGet]
        public IActionResult JobApplicationSourceDelete(int jobApplicationSourceId)
        {
           Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _jobApplicationSourceService.JobApplicationSourceDelete(jobApplicationSourceId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/JobApplicationSource/JobApplicationSourceView");
        }

    }
}
