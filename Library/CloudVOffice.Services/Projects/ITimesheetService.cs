using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
    public interface ITimesheetService
    {
        public MennsageEnum TimesheetCreate(TimesheetDTO timesheetDTO);
        public List<Timesheet> GetTimesheets();
        public Timesheet GetTimesheetByTimesheetId(Int64 timesheetId);
        public MennsageEnum TimesheetUpdate(TimesheetDTO timesheetDTO);
        public MennsageEnum TimesheetDelete(Int64 timesheetId, Int64 DeletedBy);
    }
}
