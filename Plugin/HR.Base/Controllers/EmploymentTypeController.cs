using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Web.Framework;
using CloudVOffice.Core.Domain.Common;
using Microsoft.AspNetCore.Authorization;

namespace HR.Base.Controllers
{

	[Area(AreaNames.HR)]
	public class EmploymentTypeController: BasePluginController
    {
        private readonly IEmploymentTypeService _employmentTypeService;
        public EmploymentTypeController(IEmploymentTypeService employmentTypeService)
        {
            _employmentTypeService = employmentTypeService;
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmploymentTypeCreate(int? EmploymentTypeId)
        {
            EmploymentTypeDTO employmenttypeDTO = new EmploymentTypeDTO();
         
            if (EmploymentTypeId != null)
            {

                EmploymentType d = _employmentTypeService.GetEmploymentTypeByEmploymentTypeId(int.Parse(EmploymentTypeId.ToString()));

                employmenttypeDTO.EmploymentTypeName = d.EmploymentTypeName;
                
                
            }

            return View("~/Plugins/HR.Base/Views/EmploymentType/EmploymentTypeCreate.cshtml", employmenttypeDTO);

        }
        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmploymentTypeCreate(EmploymentTypeDTO employmenttypeDTO)
        {

            employmenttypeDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			if (ModelState.IsValid)
            {
                if (employmenttypeDTO.EmploymentTypeId == null)
                {
                    var a = _employmentTypeService.EmployementTypeCreate(employmenttypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/EmploymentType/EmploymentTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmploymentType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {

                    var a = _employmentTypeService.EmploymentTypeUpdate(employmenttypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/EmploymentType/EmploymentTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmploymentType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
         

            return View("~/Plugins/HR.Base/Views/EmploymentType/EmploymentTypeCreate.cshtml", employmenttypeDTO);
        }
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmploymentTypeView()
        {
            ViewBag.EmploymentTypes = _employmentTypeService.GetEmploymentTypes();

            return View("~/Plugins/Hr.Base/Views/EmploymentType/EmploymentTypeView.cshtml");
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmploymentTypeDelete(Int64 employmenttypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _employmentTypeService.EmploymentTypeDelete(employmenttypeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/HR/EmploymentType/EmploymentTypeView");
        }
    }
}
