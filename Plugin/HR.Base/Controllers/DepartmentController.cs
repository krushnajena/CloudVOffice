using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]

    public class DepartmentController : BasePluginController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]

        public IActionResult DepartmentCreate(int? departmentId)
        {
            DepartmentDTO departmentDTO = new DepartmentDTO();
            var department = _departmentService.GetAllDepartmentGroups();
            ViewBag.ParentDepartmentList = department;

            if (departmentId != null)
            {

                Department d = _departmentService.GetDepartmentById(int.Parse(departmentId.ToString()));

                departmentDTO.DepartmentName = d.DepartmentName;
                departmentDTO.IsGroup = d.IsGroup;
                departmentDTO.Parent = d.Parent;
            }

            return View("~/Plugins/HR.Base/Views/Department/DepartmentCreate.cshtml", departmentDTO);

        }

        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DepartmentCreate(DepartmentDTO departmentDTO)
        {
            departmentDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());//
            if (ModelState.IsValid)
            {
                if (departmentDTO.DepartmentId == null)
                {
                    var a = _departmentService.CreateDepartment(departmentDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/Department/DepartmentView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Department Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _departmentService.DepartmentUpdate(departmentDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/HR/Department/DepartmentView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Department Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            ViewBag.ParentDepartmentList = new SelectList((System.Collections.IEnumerable)_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");

            return View("~/Plugins/HR.Base/Views/Department/DepartmentCreate.cshtml", departmentDTO);
        }
        [Authorize(Roles = "HR Manager")]
        public IActionResult DepartmentView()
        {
            ViewBag.Departments = _departmentService.GetDepartmentList();

            return View("~/Plugins/HR.Base/Views/Department/DepartmentView.cshtml");
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DeleteDepartment(int deprtmentid)
        {
            Int64 DeletedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _departmentService.DepartmentDelete(deprtmentid, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/HR/Department/DepartmentView");
        }


    }
}
