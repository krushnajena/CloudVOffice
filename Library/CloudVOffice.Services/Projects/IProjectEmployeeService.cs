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
	public interface IProjectEmployeeService
	{
		public MennsageEnum ProjectEmployeeCreate(ProjectEmployeeDTO projectEmployeeDTO);
		public List<ProjectEmployee> GetProjectEmployees();
		public ProjectEmployee GetProjectEmployeeByProjectEmployeeId(Int64 projectEmployeeId);
		public ProjectEmployee GetProjectEmployeeByProjectId(int projectId);
		public ProjectEmployee GetProjectEmployeeByFullName(string fullName);
		public MennsageEnum ProjectEmployeeUpdate(ProjectEmployeeDTO projectEmployeeDTO);
		public MennsageEnum ProjectEmployeeDelete(Int64 projectEmployeeId, Int64 DeletedBy);

	}
}
