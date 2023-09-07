using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class InterviewPanelService: IInterviewPanelService
	{
		private readonly ApplicationDBContext _Context;
		public InterviewPanelService(
				  ApplicationDBContext Context) {
			_Context = Context;
		}

		public List<InterviewPanel> GetInterviewPanelByScheduleId(Int64 ScheduleId)
		{
			return _Context.InterviewPanels.Where(x=>x.Deleted==false && x.InterviewScheduleId==ScheduleId).ToList();
		}
	}
}
