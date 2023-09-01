
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;


namespace CloudVOffice.Services.Recruitment
{
	public interface IJobApplicationSourceService
	{
		public MessageEnum JobApplicationSourceCreate(JobApplicationSourceDTO jobApplicationSourceDTO);
		public List<JobApplicationSource> GetJobApplicationSourceList();
		public JobApplicationSource GetJobApplicationSourceByJobApplicationSourceId(Int64 jobApplicationSourceId);
		public JobApplicationSource GetJobApplicationSourceByName(string SourceName);
		public MessageEnum JobApplicationSourceUpdate(JobApplicationSourceDTO jobApplicationSourceDTO);
		public MessageEnum JobApplicationSourceDelete(Int64 jobApplicationSourceId, Int64 DeletedBy);
	}
}
