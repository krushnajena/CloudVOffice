using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public interface IJobApplicationService
	{
		public MessageEnum JobApplicationCreate(JobApplicationDTO jobApplicationDTO);
		public List<JobApplication> GetJobApplicationList();
		public JobApplication GetJobApplicationById(Int64 JobApplicationId);
		public MessageEnum JobApplicationUpdate(JobApplicationDTO jobApplicationDTO);
		public MessageEnum JobApplicationDelete(Int64 JobApplicationId, Int64 DeletedBy);
	}
}
