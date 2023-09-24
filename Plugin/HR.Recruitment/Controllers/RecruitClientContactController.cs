using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
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
    public class RecruitClientContactController : BasePluginController
    {
        private readonly IRecruitClientContactService _recruitClientContactService;
        private readonly IRecruitClientService _recruitClientService;
        public RecruitClientContactController(IRecruitClientContactService recruitClientContactService, IRecruitClientService recruitClientService)
        {


            _recruitClientContactService = recruitClientContactService;
            _recruitClientService = recruitClientService;

        }
        [HttpGet]

        public IActionResult RecruitClientContactCreate(int? recruitClientContactId)
        {
            RecruitClientContactDTO recruitClientContactDTO = new RecruitClientContactDTO();
            var recruitClient = _recruitClientService.GetRecruitClientList();
            ViewBag.RecruitClient = recruitClient;
            if (recruitClientContactId != null)
            {

                var d = _recruitClientContactService.GetRecruitClientContactId(int.Parse(recruitClientContactId.ToString()));


                recruitClientContactDTO.RecruitClientId = d.RecruitClientId;
                recruitClientContactDTO.ContactName = d.ContactName;
                recruitClientContactDTO.ContactEmail = d.ContactEmail;
                recruitClientContactDTO.ContactPhone = d.ContactPhone;
                recruitClientContactDTO.DepartmentName = d.DepartmentName;
                recruitClientContactDTO.JobTitle = d.JobTitle;


            }

            return View("~/Plugins/HR.Recruitment/Views/RecruitClientContact/RecruitClientContactCreate.cshtml", recruitClientContactDTO);



        }
        [HttpPost]
        public IActionResult RecruitClientContactCreate(RecruitClientContactDTO recruitClientContactDTO)
        {
            recruitClientContactDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (recruitClientContactDTO.RecruitClientContactId == null)
                {
                    var a = _recruitClientContactService.RecruitClientContactCreate(recruitClientContactDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("~/Recruitment/RecruitClientContact/RecruitClientContactView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RecruitClientContact Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _recruitClientContactService.RecruitClientContactUpdate(recruitClientContactDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/RecruitClientContact/RecruitClientContactView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RecruitClientContact Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            var recruitClient = _recruitClientService.GetRecruitClientList();
            ViewBag.RecruitClient = recruitClient;
            return View("~/Plugins/HR.Recruitment/Views/RecruitClientContact/RecruitClientContactCreate.cshtml", recruitClientContactDTO);
        }
        public IActionResult RecruitClientContactView()
        {
            ViewBag.RecruitClientContact = _recruitClientContactService.GetRecruitClientContactList();

            return View("~/Plugins/HR.Recruitment/Views/RecruitClientContact/RecruitClientContactView.cshtml");
        }

        [HttpGet]
        public IActionResult RecruitClientContactDelete(int recruitClientContactId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _recruitClientContactService.RecruitClientContactDelete(recruitClientContactId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/RecruitClientContact/RecruitClientContactView");
        }

        [HttpGet]
        public JsonResult GetContactsByClientId(int clientId)
        {
            return Json(_recruitClientContactService.GetClientContractByClientId(clientId));
        }


    }
}
