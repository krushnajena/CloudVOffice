using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class EmployeeGradeController :  BasePluginController
    {
        private readonly IEmployeeGradeServices _employeeGradeService;
        public EmployeeGradeController(IEmployeeGradeServices employeeGradeService)
        {

            _employeeGradeService = employeeGradeService;
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult CreateEmployeeGrade(int? employeeGradeId)
        {
            EmployeeGradeDTO employeeGradeDTO = new EmployeeGradeDTO();
            
            if (employeeGradeId != null)
            {

                EmployeeGrade d = _employeeGradeService.GetEmployeeGradeById(int.Parse(employeeGradeId.ToString()));

                employeeGradeDTO.EmployeeGradeName = d.EmployeeGradeName;
                

            }

            return View("~/Plugins/HR.Base/Views/EmployeeGrade/CreateEmployeeGrade.cshtml", employeeGradeDTO);

        }
        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult CreateEmployeeGrade(EmployeeGradeDTO employeeGradeDTO)
        {
            employeeGradeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (employeeGradeDTO.EmployeeGradeId == null)
                {
                    var a = _employeeGradeService.CreateEmployeeGrade(employeeGradeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/EmployeeGrade/EmployeeGradeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmployeeGrade Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _employeeGradeService.CreateEmployeeGrade(employeeGradeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/HR/EmployeeGrade/EmployeeGradeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmployeeGrade Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            
            return View("~/Plugins/HR.Base/Views/EmployeeGrade/CreateEmployeeGrade.cshtml", employeeGradeDTO);
        }
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmployeeGradeView()
        {
            ViewBag.employeeGrades = _employeeGradeService.GetEmployeeGradeList();

            return View("~/Plugins/Hr.Base/Views/EmployeeGrade/EmployeeGradeView.cshtml");
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult EmployeeGradeDelete(Int64 employeeGradeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _employeeGradeService.EmployeeGradeDelete(employeeGradeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/HR/EmployeeGrade/EmployeeGradeView");
        }


    }
}
