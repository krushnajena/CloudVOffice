using CloudVOffice.Core.Domain.Common;

using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;


namespace CloudVOffice.Services.Recruitment
{
	public interface IJobApplicationService
	{
		public MessageEnum JobApplicationCreate(JobApplicationDTO jobApplicationDTO);
		public List<JobApplication> GetJobApplicationList();
		public JobApplication GetJobApplicationById(Int64 JobApplicationId);
		public MessageEnum JobApplicationUpdate(JobApplicationDTO jobApplicationDTO);
		public MessageEnum JobApplicationDelete(Int64 JobApplicationId, Int64 DeletedBy);
		public List<JobApplication> GetJobApplicationsByJobId(int JobId);
	}
}
