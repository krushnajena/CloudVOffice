using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;

using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.Projects;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.Email;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR;
using Microsoft.AspNetCore.Http;
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
        private readonly IProjectTaskService _projectTaskService;
        private readonly IHRSettingsService _hrSettingsService;


        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICompanyDetailsService _companyDetailsService;
        private readonly ILetterHeadService _letterHeadService;
        private readonly IEmailAccountService _emailAccountService;
        private readonly IEmailService _emailService;
        public TimesheetService(ApplicationDBContext Context, ISqlRepository<Timesheet> timesheetRepo,
            IProjectTaskService projectTaskService,
            IHRSettingsService hrSettingsService,




              IEmailTemplateService emailTemplateService,
             IHttpContextAccessor httpContextAccessor,
             ICompanyDetailsService companyDetailsService,
             ILetterHeadService letterHeadService,
             IEmailAccountService emailAccountService,
        IEmailService emailService,
        IEmployeeService employeeService
            )
        {

            _Context = Context;
            _timesheetRepo = timesheetRepo;
            _projectTaskService = projectTaskService;
            _hrSettingsService= hrSettingsService;

            _emailTemplateService = emailTemplateService;
            _httpContextAccessor = httpContextAccessor;
            _letterHeadService = letterHeadService;
            _companyDetailsService = companyDetailsService;
            _emailAccountService = emailAccountService;
            _emailService = emailService;
         
        }

        public List<Timesheet> GetMyTimeSheets(long EmployeeId)
        {
            try
            {
                var otherThenProjectTimesheet = _Context.Timesheets
                                             .Include(x => x.Employee)
                                                .Include(x => x.TimesheetActivityCategory)
                                             .Include(x => x.ProjectActivityType)
                                             
                                             .Where(x => x.EmployeeId == EmployeeId
                                                          && x.Deleted == false && x.TimesheetActivityType!=1
                                                         ).ToList();
                var projectTimesheets = _Context.Timesheets
                         .Include(x => x.Employee)
						   .Include(x => x.TimesheetActivityCategory)
						 .Include(x => x.ProjectActivityType)

                         .Include(x => x.Project)
                         .Include(X => X.ProjectTask).Where(x => x.EmployeeId == EmployeeId
                                                            && x.Deleted == false && x.TimesheetActivityType==1
                                                           )

                    .ToList();




              
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
                           .Include(x => x.TimesheetActivityCategory)
                                             .Include(x => x.ProjectActivityType)
                         .Include(x => x.Project)
                         .Include(X => X.ProjectTask).Where(x => x.TimesheetActivityType ==1
                                                            && x.TimeSheetApprovalStatus == 0
                                                            && x.Deleted == false
                                                            && x.Project.ProjectManager == EmployeeId && x.Project.ProjectManager != x.EmployeeId)
                    
                    .ToList();

				var projectTimesheetsToRa = _Context.Timesheets
						.Include(x => x.Employee)
                      .Include(x => x.TimesheetActivityCategory)
                                             .Include(x => x.ProjectActivityType)
                        .Include(x => x.Project)
						.Include(X => X.ProjectTask).Where(x => x.TimesheetActivityType == 1
														   && x.TimeSheetApprovalStatus == 0
														   && x.Deleted == false
                                                           && x.Project.ProjectManager == x.EmployeeId &&   x.Employee.ReportingAuthority == EmployeeId)

				   .ToList();


				var otherThenProjectTimesheet = _Context.Timesheets
                                               .Include(x => x.Employee)
                                                .Include(x => x.TimesheetActivityCategory)
                                             .Include(x => x.ProjectActivityType)

                                               .Where(x => x.TimesheetActivityType !=1
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

        public MessageEnum TimesheetApproval(TimesheetApprovalDTO timesheetApprovalDTO)
        {
            try
            {
                var timesheet = _Context.Timesheets.Where(x => x.TimesheetId == timesheetApprovalDTO.TimesheetId && x.Deleted == false).FirstOrDefault();
                
                if (timesheet != null)
                {

                    if(timesheet.TaskId !=null) 
                        _projectTaskService.UpdateTimeSheetHour(Int64.Parse(timesheet.TaskId.ToString()), timesheet.DurationInHours);
                    timesheet.TimeSheetApprovalStatus = timesheetApprovalDTO.TimeSheetApprovalStatus;
                    timesheet.TimeSheetApprovalRemarks = timesheetApprovalDTO.TimesheetApprovalRemarks;
                    timesheet.TimeSheetApprovedOn = DateTime.Now;
                    timesheet.TimesheetApprovedBy = timesheetApprovalDTO.ApprovedBy;
                    timesheet.UpdatedBy = timesheetApprovalDTO.UpdatedBy;
                    timesheet.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();

                    return timesheetApprovalDTO.TimeSheetApprovalStatus == 1? MessageEnum.Approved: MessageEnum.Rejected;
                }
                else
                {
                    return MessageEnum.Invalid;
                }

            }
            catch
            {
                throw;
            }
        }
        public List<Timesheet> GetTimeSheetWitDateRange(DateTime FromDate, DateTime ToDate, Int64 EmployeeId) { 
            return _Context.Timesheets.Where(x=>x.EmployeeId == EmployeeId && x.TimeSheetForDate>=FromDate && x.TimeSheetForDate<=ToDate && x.TimeSheetApprovalStatus!=2 && x.Deleted == false).ToList();
        }

        public List<TimeSheetLineChartModel> TimeSheetEffortAnalysis(DateTime FromDate, DateTime ToDate, Int64 EmployeeId)
        {
            List<TimeSheetLineChartModel> timeSheetLineChartModels = new List<TimeSheetLineChartModel>();
            var hrsettings = _hrSettingsService.GetHrSettings();
            double workingHours = (double)hrsettings.StandardWorkingHours * 60;
            double breakeHour = (double)hrsettings.BreakHours;
            double systemHour = (workingHours - breakeHour) / 60;
         var timeSheets =    GetTimeSheetWitDateRange(
            FromDate,
          ToDate,
            EmployeeId
            ).ToList();
            for (DateTime dt = FromDate; dt <= ToDate; dt = dt.AddDays(1))
            {
                var todayTimeSheet = timeSheets.Where(x => x.TimeSheetForDate == dt).ToList();
                double totatlTimeSpent = 0.0;
                for (int j = 0; j < todayTimeSheet.Count; j++)
                {
                    int hour = 0;
                    int min = 0;

                    if (totatlTimeSpent.ToString().Split(".").Count() == 2)
                    {
                        hour = int.Parse(totatlTimeSpent.ToString().Split(".")[0]);
                        min = int.Parse(totatlTimeSpent.ToString().Split(".")[1]);
                    }
                    else
                    {
                        hour = int.Parse(totatlTimeSpent.ToString());

                    }
                    int hour1 = 0;
                    int min1 = 0;

                    if (todayTimeSheet[j].DurationInHours.ToString().Split(".").Count() == 2)
                    {
                        hour1 = int.Parse(todayTimeSheet[j].DurationInHours.ToString().Split(".")[0]);


                        min1 = int.Parse(todayTimeSheet[j].DurationInHours.ToString().Split(".")[1]);
                    }
                    else
                    {
                        hour1 = int.Parse(todayTimeSheet[j].DurationInHours.ToString());

                    }





                    hour1 = hour1 + hour;
                    min1 = min1 + min;
                    TimeSpan hours = TimeSpan.FromMinutes(min1);
                    hour1 = hour1 + int.Parse(hours.ToString("hh"));
                    int min2 = int.Parse(hours.ToString("mm"));
                    string finalno = hour1.ToString() + "." + min2.ToString();
                    totatlTimeSpent = double.Parse(finalno);
                }
                timeSheetLineChartModels.Add(new TimeSheetLineChartModel
                {
                    ForDate = dt,
                    EffortPercentage = double.Parse(((totatlTimeSpent / systemHour) * 100).ToString("0.00"))
                });


            }
            return timeSheetLineChartModels; 
        }

        public List<Timesheet> GetNotRejectedTimesheetByProjectId(int ProjectId)
        {
            return _Context.Timesheets.Where(x=>x.ProjectId == ProjectId && x.TimeSheetApprovalStatus != 2 && x.Deleted == false ).ToList();
        }
        public void TimesheetUpdateRemiderSendNotification()
        {
            try
            {
                var list = _Context.Timesheets.Where(x=>x.TimeSheetForDate == DateTime.Today.AddDays(-1) && x.Deleted == false).ToList();
                var employees = _Context.Employees.Where(x=>list.All(a=>a.EmployeeId!=x.EmployeeId) && x.Deleted == false && x.Status == "Active").ToList();
                for(int i=0;i<employees.Count;i++)
                {
                    SendTimeSheetNotification(employees[i]);
                }
            }
            catch
            {
                throw;
            }
        }
        private async void SendTimeSheetNotification(Employee employee)
        {
            string baseUrl = "https://insider.appman.tech";

            EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplateByName("ProjectAssignment");
            string emailTemp = emailTemplate.EmailTemplateDescription.Trim();
            CompanyDetails company = _companyDetailsService.GetCompanyDetails();
            LetterHead letter = _letterHeadService.GetLetter();
            EmailAccount emailA = _emailAccountService.GetDefaultEmail(emailTemplate.DefaultSendingAccount);
            StringBuilder stringBuilder = new StringBuilder(emailTemp);
           
            if (company != null)
            {
                stringBuilder = stringBuilder.Replace("{%emailogo%}", "<img src='" + baseUrl + "/uploads/setup/" + company.CompanyLogo + "' height=\"40\" style=\"border:0;margin:auto auto 10px;max-height:40px;outline:none;text-align:center;text-decoration:none;width:auto\" align=\"center\" width=\"auto\" class=\"CToWUd\" data-bit=\"iit\" jslog=\"138226; u014N:xr6bB; 53:WzAsMl0.\">");

                stringBuilder = stringBuilder.Replace("{%companyname%}", company.CompanyName);
                stringBuilder = stringBuilder.Replace("{%address%}", company.AddressLine1 + ", " + company.AddressLine2 + ", " + company.City + ", " + company.State + ", " + company.Country + " - " + company.PostalCode);

            }
            if (emailA != null)
            {
                stringBuilder = stringBuilder.Replace("{%emailsignature%}", emailA.EmailSignature);
            }
            if (letter != null)
            {
                stringBuilder = stringBuilder.Replace("{%footerletterhera%}", "<img src='" + baseUrl + "/uploads/setup/" + letter.LetterHeadFooterImage + "' style='hight:" + letter.LetterHeadImageFooterHeight + "; width:" + letter.LetterHeadImageFooterWidth + "'>");
            }

            stringBuilder = stringBuilder.Replace("{%Name%}", employee.FirstName);

            stringBuilder = stringBuilder.Replace("{%Date%}", DateTime.Today.AddDays(-1).ToString("dd-MMM-yyyy"));

            stringBuilder = stringBuilder.Replace("{%appname%}", baseUrl);


            await _emailService.SendEmailAsync(new MailRequest
            {
                SenderEmail = emailA.EmailAddress,
                MailBoxName = emailA.EmailAccountName,
                MailBoxEmail = emailA.AlternativeEmailAddress,
                Host = emailA.EmailDomain.OutingServer,
                Port = emailA.EmailDomain.OutgoingPort,
                AuthEmail = emailA.EmailAddress,
                AuthPassword = emailA.EmailPassword,
                ToEmail = employee.CompanyEmail,
                Subject = emailTemplate.Subject,
                Body = stringBuilder.ToString()

            });

        }
    }
}
