namespace CloudVOffice.Data.ViewModel.DesktopMonitering
{
    public class EffortAnalysReportViewModel
    {
        public string EmployeeName { get; set; }
        public int TotalNoOfDaysInMonth { get; set; }
        public int TotalNoOfWorkingDays { get; set; }
        public double? EffortHourRequired { get; set; }
        public double EffortHours { get; set; }
        public double IdelHours { get; set; }
        public double ActualEffortHours { get; set; }
        public double? EffortPercentage { get; set; }

    }

    public class EmployeeDayWiseEffortAnalysViewModel
    {
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public double? EffortHourRequired { get; set; }
        public double EffortHours { get; set; }
        public double IdelHours { get; set; }
        public double ActualEffortHours { get; set; }
        public double? EffortPercentage { get; set; }

    }
}
