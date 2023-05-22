using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public interface IProjectService
	{
		public MennsageEnum ProjectCreate(ProjectDTO projectDTO);
		public List<Project> GetProjects();
		public Project GetProjectByProjectId(Int64 projectId);
		public Project GetProjectByProjectName(string projectName);
		public MennsageEnum ProjectUpdate(ProjectDTO projectDTO);
		public MennsageEnum ProjectDelete(Int64 projectId, Int64 DeletedBy);

		public List<Project> GetMyAssignedProject(Int64 EmployeeId, Int64 UserId);

		public List<Project> GetMyAssignedProjectByEmployee(Int64 EmployeeId);


	}
}
