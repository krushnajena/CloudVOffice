namespace CloudVOffice.Data.ViewModel.Projects
{
    public class ProjectTaskColumnChartModel
    {
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public double TotalTaskCount { get; set; }
        public double OpenTaskCount { get; set; }
        public double WorkingTaskCount { get; set; }
        public double ReviewTaskCount { get; set; }
        public double OverdueTaskCount { get; set; }
        public double CompletedTaskCount { get; set; }
        public double CancelledTaskCount { get; set; }
    }
    public class ProjectWiseTimesheetEffortAnalysys
    {
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public double PlannedEffortHours { get; set; }
        public double EffotHourUsed { get; set; }
    }
}
