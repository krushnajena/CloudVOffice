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
        public IActionResult EmploymentTypeCreate(EmploymentTypeDTO employmenttypeDTO)
        {

            employmenttypeDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			if (ModelState.IsValid)
            {
                if (employmenttypeDTO.EmploymentTypeId == null)
                {
                    var a = _employmentTypeService.EmployementTypeCreate(employmenttypeDTO);
                    if (a == "success")
                    {
                        return Redirect("/HR/EmploymentType/EmploymentTypeList");
                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "EmploymentType Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {

                    var a = _employmentTypeService.EmploymentTypeUpdate(employmenttypeDTO);
                    if (a == "success")
                    {

                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "EmploymentType Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
         

            return View("~/Plugins/HR.Base/Views/EmploymentType/EmploymentTypeCreate.cshtml", employmenttypeDTO);
        }









    }
}
