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
	 public interface IProjectUserService
	 {
		public MennsageEnum ProjectUserCreate(ProjectUserDTO projectUserDTO);
		public List<ProjectUser> GetProjectUsers();
		public ProjectUser GetProjectUserByProjectUserId(Int64 projectUserId);
		public MennsageEnum ProjectUserUpdate(ProjectUserDTO projectUserDTO);
		public MennsageEnum ProjectUserDelete(Int64 projectUserId, Int64 DeletedBy);

		public List<ProjectUser> GetProjectUsersByProjectId(int ProjectId);

	}
}
