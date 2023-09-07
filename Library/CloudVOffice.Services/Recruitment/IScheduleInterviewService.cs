using CloudVOffice.Data.ViewModel.Recurt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public interface IScheduleInterviewService
	{
		public List<ScheduleInterviewRoundViewModel> GetInterViewRoundsForSchedule(int JobId, Int64 ApplicationId);
	}
}
