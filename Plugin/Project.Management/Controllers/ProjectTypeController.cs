using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Projects;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Management.Controllers
{
    [Area(AreaNames.Projects)]
    public class ProjectTypeController : BasePluginController
    {
        private readonly IProjectTypeService _projectTypeService;
        public ProjectTypeController(IProjectTypeService projectTypeService)
        {
            _projectTypeService = projectTypeService;
        }
        [HttpGet]
        public IActionResult ProjectTypeCreate(int? ProjectTypeId)
        {
            ProjectTypeDTO projectTypeDTO = new ProjectTypeDTO();

            if (ProjectTypeId != null)
            {

                ProjectType d = _projectTypeService.GetProjectTypeByProjectTypeId(int.Parse(ProjectTypeId.ToString()));

                projectTypeDTO.ProjectName = d.ProjectName;


            }

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projectTypeDTO);

        }
        [HttpPost]
        public IActionResult ProjectTypeCreate(ProjectTypeDTO projectTypeDTO)
        {

            projectTypeDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            if (ModelState.IsValid)
            {
                if (projectTypeDTO.ProjectTypeId == null)
                {
                    var a = _projectTypeService.ProjectTypeCreate(projectTypeDTO);
                    if (a == MennsageEnum.Success)
                    {
                        return Redirect("/Projects/ProjectType/ProjectTypeView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "ProjectType Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {

                    var a = _projectTypeService.ProjectTypeUpdate(projectTypeDTO);
                    if (a == MennsageEnum.Success)
                    {
                        return Redirect("/Projects/ProjectType/ProjectTypeView");
                    }
                    else if (a == MennsageEnum.Duplicate)
                    {
                        ModelState.AddModelError("", "ProjectType Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projectTypeDTO);
        }
        public IActionResult ProjectTypeView()
        {
            ViewBag.ProjectTypes = _projectTypeService.GetProjectTypes();

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeView.cshtml");
        }
        public IActionResult ProjectTypeDelete(Int64 projectTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _projectTypeService.ProjectTypeDelete(projectTypeId, DeletedBy);
            return Redirect("/Projects/ProjectType/ProjectTypeView");
        }
    }
}