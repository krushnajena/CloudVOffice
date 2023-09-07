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
    public class RecruitClientDocumentController : BasePluginController
    {
        private readonly IRecruitClientDocumentService _recruitClientDocumentService;
        private readonly IRecruitClientService _recruitClientService;
        public RecruitClientDocumentController(IRecruitClientDocumentService recruitClientDocumentService, IRecruitClientService recruitClientService)
        {
            _recruitClientDocumentService = recruitClientDocumentService;
            _recruitClientService = recruitClientService;
            
        }
        [HttpGet]
        public IActionResult RecruitClientDocumentCreate(int? recruitClientDocumentId)
        {
            RecruitClientDocumentDTO recruitClientDocumentDTO = new RecruitClientDocumentDTO();
            var recruitClient = _recruitClientService.GetRecruitClientList();
            ViewBag.RecruitClient = recruitClient;

            if (recruitClientDocumentId != null)
            {

                var d = _recruitClientDocumentService.GetRecruitClientDocumentById(int.Parse(recruitClientDocumentId.ToString()));

                recruitClientDocumentDTO.RecruitClientId = d.RecruitClientId;
                recruitClientDocumentDTO.DocumentType = d.DocumentType;
                recruitClientDocumentDTO.Document = d.Document;

            }

            return View("~/Plugins/HR.Recruitment/Views/RecruitClientDocument/RecruitClientDocumentCreate.cshtml", recruitClientDocumentDTO);

        }

        [HttpPost]
        public IActionResult RecruitClientDocumentCreate(RecruitClientDocumentDTO recruitClientDocumentDTO)
        {
            recruitClientDocumentDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (recruitClientDocumentDTO.RecruitClientDocumentId == null)
                {
                    var a = _recruitClientDocumentService.RecruitClientDocumentCreate(recruitClientDocumentDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("~/Recruitment/RecruitClientDocument/RecruitClientDocumentView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Recruit Client Document Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _recruitClientDocumentService.RecruitClientDocumentUpdate(recruitClientDocumentDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/RecruitClientDocument/RecruitClientDocumentView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Recruit Client Document Already Exists");
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

            return View("~/Plugins/HR.Recruitment/Views/RecruitClientDocument/RecruitClientDocumentCreate.cshtml", recruitClientDocumentDTO);
        }

        public IActionResult RecruitClientDocumentView()
        {
            ViewBag.recruitClientDocument = _recruitClientDocumentService.GetRecruitClientDocumentList();

            return View("~/Plugins/HR.Recruitment/Views/RecruitClientDocument/RecruitClientDocumentView.cshtml");
        }

        [HttpGet]
        public IActionResult RecruitClientDocumentDelete(int recruitClientDocumentId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _recruitClientDocumentService.RecruitClientDocumentDelete(recruitClientDocumentId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/RecruitClientDocument/RecruitClientDocumentView");
        }
    }
}
