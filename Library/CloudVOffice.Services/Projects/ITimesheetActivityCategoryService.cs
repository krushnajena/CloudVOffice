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
	public interface ITimesheetActivityCategoryService
	{
		public MessageEnum TimesheetActivityCategoryCreate(TimesheetActivityCategoryDTO timesheetActivityCategoryDTO);
		public List<TimesheetActivityCategory>GetTimesheetActivityCategories();
		public TimesheetActivityCategory GetTimesheetActivityCategoryByTimesheetActivityCategoryId(int timesheetActivityCategoryId);
		public TimesheetActivityCategory GetTimesheetActivityCategoryByTimesheetActivityCategoryName (string timesheetActivityCategoryName);
		public MessageEnum TimesheetActivityCategoryUpdate(TimesheetActivityCategoryDTO timesheetActivityCategoryDTO);
		public MessageEnum TimesheetActivityCategoryDelete(int timesheetActivityCategoryId, Int64 DeletedBy);

	}
}
