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
        private readonly IProjectTypeService _projecttypeService;
        public ProjectTypeController(IProjectTypeService projecttypeService)
        {

            _projecttypeService = projecttypeService;
        }
        [HttpGet]
        public IActionResult ProjectTypeCreate(int? projecttypeId)
        {
            ProjectTypeDTO projecttypeDTO = new ProjectTypeDTO();
           
            if (projecttypeId != null)
            {

                ProjectType d = _projecttypeService.GetProjectTypeByProjectTypeId(int.Parse(projecttypeId.ToString()));

                projecttypeDTO.ProjectName = d.ProjectName;

            }

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projecttypeDTO);

        }

        [HttpPost]
        public IActionResult ProjectTypeCreate(ProjectTypeDTO projecttypeDTO)
        {
            projecttypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (projecttypeDTO.ProjectTypeId == null)
                {
                    var a = _projecttypeService.ProjectTypeCreate(projecttypeDTO);
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
                    var a = _projecttypeService.ProjectTypeUpdate(projecttypeDTO);
                    if (a == MennsageEnum.Updated)
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
           

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeCreate.cshtml", projecttypeDTO);
        }

        public IActionResult ProjectTypeView()
        {
            ViewBag.projecttypes = _projecttypeService.GetProjectTypes();

            return View("~/Plugins/Project.Management/Views/ProjectType/ProjectTypeView.cshtml");
        }
        public IActionResult ProjectTypeDelete(int projectTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _projecttypeService.ProjectTypeDelete(projectTypeId, DeletedBy);
            return Redirect("/Projects/ProjectType/ProjectTypeView");
        }
    }
}
