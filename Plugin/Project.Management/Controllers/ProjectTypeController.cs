using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Services.Projects;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Management.Controllers
{
    [Area(AreaNames.Projects)]
    public class ProjectTypeController : BasePluginController
    {
        private readonly IProjectTypeService _projecttypeService;
        public ProjectTypeController(IProjectTypeService projecttypeService)
        {

            _projecttypeService = projecttypeService;
        }
        [HttpGet]
		[Authorize(Roles = "Project Manager,Project User")]
		public IActionResult ProjectTypeCreate(int? projecttypeId)
        {
            ProjectTypeDTO projecttypeDTO = new ProjectTypeDTO();

            if (projecttypeId != null)
            {

                ProjectType d = _projecttypeService.GetProjectTypeByProjectTypeId(int.Parse(projecttypeId.ToString()));

                projecttypeDTO.ProjectTypeName = d.ProjectTypeName;

            }

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projecttypeDTO);

        }

        [HttpPost]
		[Authorize(Roles = "Project Manager,Project User")]
		public IActionResult ProjectTypeCreate(ProjectTypeDTO projecttypeDTO)
        {
            projecttypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (projecttypeDTO.ProjectTypeId == null)
                {
                    var a = _projecttypeService.ProjectTypeCreate(projecttypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Projects/ProjectType/ProjectTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "ProjectType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _projecttypeService.ProjectTypeUpdate(projecttypeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Projects/ProjectType/ProjectTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "ProjectType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }


            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projecttypeDTO);
        }
		[Authorize(Roles = "Project Manager,Project User")]
		public IActionResult ProjectTypeView()
        {
            ViewBag.projecttypes = _projecttypeService.GetProjectTypes();

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeView.cshtml");
        }
		[Authorize(Roles = "Project Manager,Project User")]
		public IActionResult ProjectTypeDelete(int projectTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _projecttypeService.ProjectTypeDelete(projectTypeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Projects/ProjectType/ProjectTypeView");
        }
    }
}
