using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.ViewModel.Projects;
using System.Data;

namespace CloudVOffice.Services.Projects
{
    public interface ITimesheetService
    {
        public MessageEnum TimesheetCreate(TimesheetDTO timesheetDTO);
        public List<Timesheet> GetTimesheets();
        public Timesheet GetTimesheetByTimesheetId(Int64 timesheetId);
        public MessageEnum TimesheetUpdate(TimesheetDTO timesheetDTO);
        public MessageEnum TimesheetDelete(Int64 timesheetId, Int64 DeletedBy);

        public List<Timesheet> GetTimeSheetsToValidate(Int64 EmployeeId);

        public List<Timesheet> GetMyTimeSheets(Int64 EmployeeId);

        public MessageEnum TimesheetApproval(TimesheetApprovalDTO timesheetApprovalDTO);
        public List<Timesheet> GetTimeSheetWitDateRange(DateTime FromDate, DateTime ToDate, Int64 EmployeeId);

        public List<TimeSheetLineChartModel> TimeSheetEffortAnalysis(DateTime FromDate, DateTime ToDate, Int64 EmployeeId);
       // public void GetEffortHoursReport(Int64 EmployeeId, Int64 UserId, int Month, int Year);
        public List<Timesheet> GetNotRejectedTimesheetByProjectId(int ProjectId);
        public Task TimesheetUpdateRemiderSendNotification();
        //     public List<ProjectEmployeeWiseEffortReportViewModel> ProjectEmployeeWiseEffortReport(Int64 EmployeeId, Int64 UserId);



        public List<ProjectWiseTimesheetEffortAnalysys> GetProjectWiseTimesheetEffortAnalysys(Int64 EmployeeId, Int64 UserId);

        public List<ProjectEmployeeWiseEffortReportViewModel> ProjectEmployeeWiseEffortReport(Int64 EmployeeId, Int64 UserId);

        public DataTable GetEffortHoursReport(Int64 EmployeeId, Int64 UserId, int Month, int Year);


    }
}
