using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Services.Projects;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Web.Framework;
using Microsoft.CodeAnalysis;
using CloudVOffice.Services.Emp;
using Newtonsoft.Json;
using static LinqToDB.Common.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Projects.Management.Controller
{
	[Area(AreaNames.Projects)]
	public class ProjectController : BasePluginController
	{
		private readonly IProjectService _projectService;
        private readonly IProjectTypeService _projectTypeService;
		private readonly IEmployeeService _empolyeeService;
		private readonly IUserService _userService;
		public ProjectController(IProjectService projectService, IProjectTypeService projectTypeService, IEmployeeService empolyeeService,
			IUserService userService
			)
		{

			_projectService = projectService;
            _projectTypeService= projectTypeService;
			_empolyeeService = empolyeeService;
			_userService = userService;

		}
		public IActionResult Dashboard()
		{
			return View("~/Plugins/Project.Management/Views/Project/Dashboard.cshtml");
		}
        [HttpGet]	
		public IActionResult ProjectCreate(int? projectId)
		{
			ProjectDTO projectDTO = new ProjectDTO();
			
			ViewBag.ProjectTypes = _projectTypeService.GetProjectTypes();
			var projectManager = _empolyeeService.GetProjectManagerEmployees();
			ViewBag.ProjectManager = projectManager;

			var employees = _empolyeeService.GetEmployees();
			ViewBag.Employees = employees;

			ViewBag.Users= _userService.GetAllUsers();
			projectDTO.ProjectEmployees = new List<ProjectEmployee>();
			if (projectId != null)
			{

				CloudVOffice.Core.Domain.Projects.Project d = _projectService.GetProjectByProjectId(int.Parse(projectId.ToString()));

				projectDTO.ProjectCode = d.ProjectCode;
				projectDTO.ProjectName = d.ProjectName;
				projectDTO.StartDate = d.StartDate;
				projectDTO.EndDate = d.EndDate;
				projectDTO.Status = d.Status;
				projectDTO.ProjectTypeId = d.ProjectTypeId;
				projectDTO.Priority = d.Priority;
				projectDTO.CompleteMethod = d.CompleteMethod;
				projectDTO.CustomerId = d.CustomerId;
				projectDTO.Status = d.Status;
				projectDTO.SalesOrderId = d.SalesOrderId;
				projectDTO.ProjectNotes = d.ProjectNotes;
				projectDTO.EstimatedCost = d.EstimatedCost;
				projectDTO.ProjectManager = d.ProjectManager;
				
				

			}

			return View("~/Plugins/Project.Management/Views/Project/ProjectCreate.cshtml", projectDTO);

		}
		[HttpPost]
		public IActionResult ProjectCreate(ProjectDTO projectDTO)
		{
			projectDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			var objects = JsonConvert.DeserializeObject<List<ProjectEmployee>>(projectDTO.ProjectEmployeeString);
			projectDTO.ProjectEmployees = objects;
			if (ModelState.IsValid)
			{
				if (projectDTO.ProjectId == null)
				{
					var a = _projectService.ProjectCreate(projectDTO);
					if (a == MennsageEnum.Success)
					{
						return Redirect("/Projects/Project/ProjectView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Project Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _projectService.ProjectUpdate(projectDTO);
					if (a == MennsageEnum.Updated)
					{
						return Redirect("/Projects/Project/ProjectView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Project Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}


            ViewBag.ProjectTypes = _projectTypeService.GetProjectTypes();
			var projectManager = _empolyeeService.GetProjectManagerEmployees();
			ViewBag.ProjectManager = projectManager;

			var employees = _empolyeeService.GetEmployees();
			ViewBag.Employees = employees;

			ViewBag.Users = _userService.GetAllUsers();
			return View("~/Plugins/Project.Management/Views/Project/ProjectCreate.cshtml", projectDTO);
		}
		public IActionResult ProjectView()
		{
			ViewBag.Projects = _projectService.GetProjects();

			return View("~/Plugins/Project.Management/Views/Project/ProjectView.cshtml");
		}
        [HttpGet]
        public IActionResult ProjectDelete(Int64 projectId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _projectService.ProjectDelete(projectId, DeletedBy);
            return Redirect("/Projects/Project/ProjectView");
        }
    }
}
