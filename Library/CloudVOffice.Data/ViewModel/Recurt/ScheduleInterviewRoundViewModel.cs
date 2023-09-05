using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.Recurt
{
	public class ScheduleInterviewRoundViewModel
	{
		public int InterviewRoundId { get; set; }
		public string InterviewRoundName { get;set; }
		public DateTime? ScheduledOn { get; set; }
		public int? Status { get; set; } //0= Scheduled,1=Recommanded,2= Not-Recommanded,3= NoShow,4= Waiting For Feedback
		public int ButtonFlag { get; set; }//0=Hilde,1=Reschedule,2 = Schedule, 3 = Release Offer
		public int Order { get; set; }
		
	}
}
