using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class DesignationContoller : BasePluginController
    {
        private readonly IDesignationService _designationService;
        public DesignationContoller(IDesignationService designationService)
        {
            _designationService = designationService;
        }

        [HttpGet]
        public IActionResult DesignationCreate(int? DesignationId)
        {
            DesignationDTO designationDTO = new DesignationDTO();
            if (DesignationId != null)
            {

                Designation d = _designationService.GetDesignationById(int.Parse(DesignationId.ToString()));

                designationDTO.DesignationName = d.DesignationName;

            }

            return View("~/Plugins/HR.Base/Views/Designation/DesignationCreate.cshtml", designationDTO);

        }
        [HttpPost]
        public IActionResult DesignationCreate(DesignationDTO designationDTO)
        {
            designationDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            if (ModelState.IsValid)
            {
                if (designationDTO.DesignationId == null)
                {
                    var a = _designationService.CreateDesignation(designationDTO);
                    if (a == "success")
                    {
                        return Redirect("/HR/Designation/DesignationList");
                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "Designation Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _designationService.DesignationUpdate(designationDTO);
                    if (a == "success")
                    {

                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "Designation Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            return View("~/Plugins/HR.Base/Views/Designation/DesignationCreate.cshtml", designationDTO);
        }

        public IActionResult DesignationView()
        {
            ViewBag.branches = _designationService.GetDesignationList();

            return View("~/Plugins/HR.Base/Views/Designation/DesignationView.cshtml");
        }
    }
}
