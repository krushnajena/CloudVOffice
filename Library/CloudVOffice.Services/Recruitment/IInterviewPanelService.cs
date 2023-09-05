using CloudVOffice.Core.Domain.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public interface IInterviewPanelService
	{
		public List<InterviewPanel> GetInterviewPanelByScheduleId(Int64 ScheduleId);
	}
}
