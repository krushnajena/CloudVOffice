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
	public interface IProjectActivityTypeService
	{
		public MessageEnum ProjectActivityTypeCreate(ProjectActivityTypeDTO projectActivityTypeDTO);
		public List<ProjectActivityType> GetProjectActivityTypes();
		public ProjectActivityType GetProjectActivityTypeByProjectActivityTypeId(Int64 projectActivityTypeId);
		public ProjectActivityType GetProjectActivityTypeByProjectActivityName(string projectActivityName);
		public MessageEnum ProjectActivityTypeUpdate(ProjectActivityTypeDTO projectActivityTypeDTO);
		public MessageEnum ProjectActivityTypeDelete(Int64 projectActivityTypeId, Int64 DeletedBy);

		public List<ProjectActivityType> GetProjectActivityTypesByActivityCategory(string activityCategory);	
	}
}
