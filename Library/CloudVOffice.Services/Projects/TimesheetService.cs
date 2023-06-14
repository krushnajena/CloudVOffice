using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;

using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<Timesheet> _timesheetRepo;
        public TimesheetService(ApplicationDBContext Context, ISqlRepository<Timesheet> timesheetRepo)
        {

            _Context = Context;
            _timesheetRepo = timesheetRepo;
        }

        public List<Timesheet> GetMyTimeSheets(long EmployeeId)
        {
            try
            {
                var projectTimesheets = _Context.Timesheets
                         .Include(x => x.Employee)
                         .Include(x => x.ProjectActivityType)
                         .Include(x => x.Project)
                         .Include(X => X.ProjectTask).Where(x => x.EmployeeId == EmployeeId
                                                            && x.Deleted == false && x.ProjectId != null
                                                           )

                    .ToList();




                var otherThenProjectTimesheet = _Context.Timesheets
                                               .Include(x => x.Employee)
                                               .Include(x => x.ProjectActivityType).Where(x => x.EmployeeId == EmployeeId
                                                            && x.Deleted == false && x.ProjectId == null
                                                           );
                projectTimesheets.AddRange(otherThenProjectTimesheet);
               
                return projectTimesheets;
            }
            catch
            {
                throw;
            }
        }

        public Timesheet GetTimesheetByTimesheetId(Int64 timesheetId)
        {
            try
            {
                return _Context.Timesheets.Where(x => x.TimesheetId == timesheetId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<Timesheet> GetTimesheets()
        {
            try
            {
                return _Context.Timesheets.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public List<Timesheet> GetTimeSheetsToValidate(Int64 EmployeeId)
        {
            try
            {
                var projectTimesheets = _Context.Timesheets
                         .Include(x => x.Employee)
                         .Include(x => x.ProjectActivityType)
                         .Include(x => x.Project)
                         .Include(X => X.ProjectTask).Where(x => x.TimesheetActivityType ==1
                                                            && x.TimeSheetApprovalStatus == 0
                                                            && x.Deleted == false
                                                            && x.Project.ProjectManager == EmployeeId && x.Project.ProjectManager != x.EmployeeId)
                    
                    .ToList();

				var projectTimesheetsToRa = _Context.Timesheets
						.Include(x => x.Employee)
						.Include(x => x.ProjectActivityType)
						.Include(x => x.Project)
						.Include(X => X.ProjectTask).Where(x => x.TimesheetActivityType == 1
														   && x.TimeSheetApprovalStatus == 0
														   && x.Deleted == false
                                                           && x.Project.ProjectManager == x.EmployeeId &&   x.Employee.ReportingAuthority == EmployeeId)

				   .ToList();


				var otherThenProjectTimesheet = _Context.Timesheets
                                               .Include(x => x.Employee)
                                               .Include(x => x.ProjectActivityType).Where(x => x.TimesheetActivityType !=1
                                                            && x.TimeSheetApprovalStatus == 0
                                                            && x.Deleted == false
                                                            && x.Employee.ReportingAuthority ==  EmployeeId);
                projectTimesheets.AddRange(otherThenProjectTimesheet);
				projectTimesheets.AddRange(projectTimesheetsToRa);
				return projectTimesheets;
            }
            catch{
                throw;
            }
        }

        public MessageEnum TimesheetCreate(TimesheetDTO timesheetDTO)
        {

            var objCheck = _Context.Timesheets.SingleOrDefault(opt => opt.TimesheetId == timesheetDTO.TimesheetId && opt.Deleted == false);
            try
            {
                
                

                    Timesheet timesheet = new Timesheet();
                    timesheet.TimeSheetForDate = timesheetDTO.TimeSheetForDate;
                    timesheet.EmployeeId = timesheetDTO.EmployeeId;
                    timesheet.TimesheetActivityType = timesheetDTO.TimesheetActivityType;
                    timesheet.ActivityId = timesheetDTO.ActivityId;
                    timesheet.ProjectId = timesheetDTO.ProjectId;
                    timesheet.TaskId = timesheetDTO.TaskId;
                    timesheet.FromTime = timesheetDTO.FromTime;
                    timesheet.ToTime = timesheetDTO.ToTime;
                    timesheet.DurationInHours = timesheetDTO.DurationInHours;
                    timesheet.Description = timesheetDTO.Description;
                    timesheet.IsBillable = timesheetDTO.IsBillable;
                    timesheet.HourlyRate = timesheetDTO.HourlyRate;
                    timesheet.TimeSheetApprovalStatus = 0;
                  

                    timesheet.CreatedBy = timesheetDTO.CreatedBy;
                    var obj = _timesheetRepo.Insert(timesheet);

               
                
                

                return MessageEnum.Success;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum TimesheetDelete(Int64 timesheetId, Int64 DeletedBy)
        {

            try
            {
                var a = _Context.Timesheets.Where(x => x.TimesheetId == timesheetId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum TimesheetUpdate(TimesheetDTO timesheetDTO)
        {

            try
            {
                var timesheet = _Context.Timesheets.Where(x => x.TimesheetId == timesheetDTO.TimesheetId && x.Deleted == false).FirstOrDefault();
                if (timesheet == null)
                {
                    var a = _Context.Timesheets.Where(x => x.TimesheetId == timesheetDTO.TimesheetId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = timesheetDTO.EmployeeId;
                        a.TimeSheetForDate = timesheetDTO.TimeSheetForDate;
                        a.TimesheetActivityType = timesheetDTO.TimesheetActivityType;
                        a.ActivityId = timesheetDTO.ActivityId;
                        a.ProjectId = timesheetDTO.ProjectId;
                        a.TaskId = timesheetDTO.TaskId;
                        a.FromTime = timesheetDTO.FromTime;
                        a.ToTime = timesheetDTO.ToTime;
                        a.DurationInHours = timesheetDTO.DurationInHours;
                        a.Description = timesheetDTO.Description;
                        a.IsBillable = timesheetDTO.IsBillable;
                        a.HourlyRate = timesheetDTO.HourlyRate;
                        a.TimeSheetApprovalStatus = timesheetDTO.TimeSheetApprovalStatus;
                        a.TimesheetApprovedBy = timesheetDTO.TimesheetApprovedBy;
                        a.TimeSheetApprovedOn = timesheetDTO.TimeSheetApprovedOn;
                        a.TimeSheetApprovalRemarks = timesheetDTO.TimeSheetApprovalRemarks;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
