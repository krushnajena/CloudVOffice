using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.Recurt;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class ScheduleInterviewService : IScheduleInterviewService
	{
		private readonly IJobOpeningService _jobOpeningService;
		private readonly IJobApplicationService _jobApplicationService;
		private readonly IInterviewRoundService _inerviewRoundService;
		private readonly ISqlRepository<InterviewSchedule> _interviewScheduleRepo;

		private readonly IInterviewPanelService _interviewPanelService;
		private readonly ApplicationDBContext _Context;
		public ScheduleInterviewService(IJobOpeningService jobOpeningService,
			 IJobApplicationService jobApplicationService,
			 IInterviewRoundService inerviewRoundService,
			 ISqlRepository<InterviewSchedule> interviewScheduleRepo,
			  ApplicationDBContext Context,
			  IInterviewPanelService interviewPanelService

			)
		{
			_jobOpeningService = jobOpeningService;
			_jobApplicationService = jobApplicationService;

			_inerviewRoundService = inerviewRoundService;
			_interviewScheduleRepo = interviewScheduleRepo;
			_Context= Context;
			_interviewPanelService = interviewPanelService;
		}

		public List<ScheduleInterviewRoundViewModel> GetInterViewRoundsForSchedule(int JobId, long ApplicationId)
		{
			List<ScheduleInterviewRoundViewModel> result = new List<ScheduleInterviewRoundViewModel>();
			var job = _jobOpeningService.GetJobOpeningByJobOpeningId(JobId);
			//var interviewRounds = _inerviewRoundService.GetInterviewRoundsByDesignationId(int.Parse(job.DesignationId.ToString())).OrderByDescending(x=>x.InterviewRoundOrder).ToList();
			//for(int i = 0; i < interviewRounds.Count; i++)
			//{
			//	var inertview  = _Context.InterviewSchedules.Where(x=>x.ApplicationId == ApplicationId && x.JobId == JobId && x.RoundId == interviewRounds[i].InterviewRoundId).ToList();
			//	int flag = 0;
			//	int status = 0;
			//	if (inertview.Count > 0)
			//	{
			//		var interviewSc = inertview[inertview.Count-1];
					
			//		if (interviewSc.Status == 6)
			//		{
			//			var inp = _interviewPanelService.GetInterviewPanelByScheduleId(interviewSc.InterviewScheduleId);
			//			bool presult = true;
			//			int reccount = 0;
			//			int nrec = 0;
			//			for(int j = 0; j < inp.Count; j++)
			//			{
			//				if (inp[j].InetrviewStatus == 1)
			//				{
			//					reccount = reccount + 1;
			//				}

			//				else if (inp[j].InetrviewStatus == 2)
			//				{
			//					nrec = nrec + 1;
			//				}
			//			}
			//			if(reccount > nrec && i == 0)
			//			{
			//				flag = 4;
			//			}
						
			//		}
			//		else if (interviewSc.Status == 2)
			//		{
			//			flag = 3;
			//		}
			//		else if (interviewSc.Status == 3 || interviewSc.Status == 4)
			//		{
			//			flag = 3;
			//		}



			//	}

			//	else
			//	{
			//		if (i + 1 < interviewRounds.Count)
			//		{
			//			var ninertview = _Context.InterviewSchedules.Where(x => x.ApplicationId == ApplicationId && x.JobId == JobId && x.RoundId == interviewRounds[i + 1].InterviewRoundId).ToList();
			//			if (ninertview.Count > 0)
			//			{
			//				var interviewSc = ninertview[ninertview.Count - 1];

			//				if (interviewSc.Status == 6)
			//				{
			//					var inp = _interviewPanelService.GetInterviewPanelByScheduleId(interviewSc.InterviewScheduleId);
								
			//					int reccount = 0;
			//					int nrec = 0;
			//					for (int j = 0; j < inp.Count; j++)
			//					{
			//						if (inp[j].InetrviewStatus == 1)
			//						{
			//							reccount = reccount + 1;
			//						}

			//						else if (inp[j].InetrviewStatus == 2)
			//						{
			//							nrec = nrec + 1;
			//						}
			//					}
			//					if (reccount > nrec && i == 0)
			//					{
			//						flag = 2;
			//					}

			//				}
			//				else if (interviewSc.Status == 2)
			//				{
			//					flag = 0;
			//				}
			//				else if (interviewSc.Status == 3 || interviewSc.Status == 4)
			//				{
			//					flag = 0;
			//				}

			//			}
			//			else
			//			{
			//				flag = 0;
			//			}
						
			//		}
			//		else
			//		{
			//			flag = 2;
			//		}
			//	}



			//	if (inertview.Count == 0)
			//		result.Add(new ScheduleInterviewRoundViewModel
			//		{
			//			InterviewRoundId = interviewRounds[i].InterviewRoundId,
			//			InterviewRoundName = interviewRounds[i].InterviewRoundName,
			//			ScheduledOn = null,
			//			Status = -1,
			//			ButtonFlag = flag,
			//			Order = interviewRounds[i].InterviewRoundOrder,
			//		});
			//	else
			//	{
			//		result.Add(new ScheduleInterviewRoundViewModel
			//		{
			//			InterviewRoundId = interviewRounds[i].InterviewRoundId,
			//			InterviewRoundName = interviewRounds[i].InterviewRoundName,
			//			ScheduledOn = inertview[i].ScheduledOn ,
			//			Status = -1,
			//			ButtonFlag = flag,
			//			Order = interviewRounds[i].InterviewRoundOrder,
			//		});
			//	}
			//}


			return result.OrderBy(x=>x.Order).ToList();

		}
	}
}
