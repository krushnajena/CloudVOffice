using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.ViewModel.Projects;
using StackExchange.Profiling.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Timesheet> GetNotRejectedTimesheetByProjectId(int ProjectId);
        public  Task TimesheetUpdateRemiderSendNotification();

    }
}
