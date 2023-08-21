namespace CloudVOffice.Core.Domain.Projects
{
    public class ProjectTaskStatusLog
    {
        public Int64 ProjectTaskStatusLogId { get; set; }
        public Int64 TaskId { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }

    }
}
