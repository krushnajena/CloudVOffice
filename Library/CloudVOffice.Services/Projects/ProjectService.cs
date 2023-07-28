using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.Projects;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.Email;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectService : IProjectService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<Project> _projectRepo;

		private readonly IProjectUserService _projectUserService;

		private readonly IProjectEmployeeService _projectEmployeeService;
		private readonly IProjectTaskService _projectTaskService;
        private readonly ITimesheetService _timeSheetService;
		private readonly IEmployeeService _employeeService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICompanyDetailsService _companyDetailsService;
        private readonly ILetterHeadService _letterHeadService;
        private readonly IEmailAccountService _emailAccountService;
        private readonly IEmailService _emailService;
        public ProjectService(ApplicationDBContext Context, ISqlRepository<Project> projectRepo,
			 IProjectEmployeeService projectEmployeeService,
			 IProjectUserService projectUserService, IProjectTaskService projectTaskService,
             ITimesheetService timeSheetService,


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
			_projectRepo = projectRepo;
			_projectUserService = projectUserService;
			_projectEmployeeService = projectEmployeeService;
			_projectTaskService = projectTaskService;
            _timeSheetService= timeSheetService;
            _emailTemplateService = emailTemplateService;
            _httpContextAccessor = httpContextAccessor;
            _letterHeadService = letterHeadService;
            _companyDetailsService = companyDetailsService;
            _emailAccountService = emailAccountService;
            _emailService = emailService;
			_employeeService = employeeService;

        }

		public List<Project> GetMyAssignedProject(Int64 EmployeeId, Int64 UserId)
		{
			try
			{
				return _Context.Projects
					.Include(e=>e.Employee)
					.Include(s=>s.ProjectEmployees)
					.Include(t=>t.ProjectUsers)
					.Where(x => x.Deleted == false && ( x.ProjectManager == EmployeeId
					|| x.ProjectEmployees.Any(d=>d.EmployeeId == EmployeeId && d.Deleted == false)
					|| x.ProjectUsers.Any(d => d.UserId == UserId && d.Deleted == false))
					).ToList();
			}
			catch
			{
				throw;
			}
		}

		public List<Project> GetMyAssignedProjectByEmployee(Int64 EmployeeId)
		{
			try
			{
				return  _Context.Projects
					.Include(e => e.Employee)
					.Include(s => s.ProjectEmployees)
					.Where(x => x.Deleted == false && (x.ProjectManager == EmployeeId
					|| x.ProjectEmployees.Any(d => d.EmployeeId == EmployeeId && d.Deleted == false))
					).ToList();
			}
			catch
			{
				throw;
			}
		}

		public Project GetProjectByProjectId(Int64 projectId)
		{
			try
			{
				return _Context.Projects.Where(x => x.ProjectId == projectId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public Project GetProjectByProjectName(string projectName)
		{
			try
			{
				return _Context.Projects.Where(x => x.ProjectName == projectName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<Project> GetProjects()
		{
			try
			{
				return _Context.Projects
					.Include(x=>x.ProjectType)
					.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

			

		public MessageEnum ProjectCreate(ProjectDTO projectDTO)
		{
			var objCheck = _Context.Projects.SingleOrDefault(opt => opt.ProjectId == projectDTO.ProjectId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					Project project = new Project();
					project.ProjectCode = projectDTO.ProjectCode;
					project.ProjectName = projectDTO.ProjectName;
					project.StartDate = projectDTO.StartDate;
					project.EndDate = projectDTO.EndDate;
					project.Status = projectDTO.Status;
                    project.EffortHourRequired = projectDTO.EffortHourRequired;
                    project.ProjectTypeId = projectDTO.ProjectTypeId;
					project.Priority = projectDTO.Priority;
					project.CompleteMethod = projectDTO.CompleteMethod;
					project.CustomerId = projectDTO.CustomerId;
					project.SalesOrderId = projectDTO.SalesOrderId;
					project.ProjectNotes = projectDTO.ProjectNotes;
					project.EstimatedCost = projectDTO.EstimatedCost;
					project.ProjectManager = projectDTO.ProjectManager;
					project.CreatedBy = projectDTO.CreatedBy;
					var obj = _projectRepo.Insert(project);
					var projectEmployee = JsonConvert.DeserializeObject<List<ProjectEmployeeDTO>>(projectDTO.ProjectEmployeeString);

					for (int i = 0; i < projectEmployee.Count; i++)
					{
						projectEmployee[i].CreatedBy = projectDTO.CreatedBy;
						projectEmployee[i].ProjectId = obj.ProjectId;
					
						_projectEmployeeService.ProjectEmployeeCreate(projectEmployee[i]);
					}


					var projectUser = JsonConvert.DeserializeObject<List<ProjectUserDTO>>(projectDTO.ProjectUsersString);

					for (int i = 0; i < projectUser.Count; i++)
					{
						projectUser[i].CreatedBy = projectDTO.CreatedBy;
						projectUser[i].ProjectId = obj.ProjectId;
						_projectUserService.ProjectUserCreate(projectUser[i]);
					}
					SendProjectAssignmentNotification(projectDTO);

                    return MessageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MessageEnum.Duplicate;
				}

				return MessageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum ProjectDelete(Int64 projectId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.Projects.Where(x => x.ProjectId == projectId).FirstOrDefault();
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

		public MessageEnum ProjectUpdate(ProjectDTO projectDTO)
		{
			try
			{
				var project = _Context.Projects.Where(x => x.ProjectId == projectDTO.ProjectId && x.ProjectCode == projectDTO.ProjectCode && x.Deleted == false).FirstOrDefault();
				if (project == null)
				{
					var a = _Context.Projects.Where(x => x.ProjectId == projectDTO.ProjectId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectCode = projectDTO.ProjectCode;
						a.ProjectName = projectDTO.ProjectName;
						a.StartDate = projectDTO.StartDate;
						a.EndDate = projectDTO.EndDate;
						a.Status = projectDTO.Status;
                        a.EffortHourRequired = projectDTO.EffortHourRequired;
                        a.ProjectTypeId = projectDTO.ProjectTypeId;
						a.Priority = projectDTO.Priority;
						a.CompleteMethod = projectDTO.CompleteMethod;
						a.CustomerId = projectDTO.CustomerId;
						a.SalesOrderId = projectDTO.SalesOrderId;
						a.ProjectNotes = projectDTO.ProjectNotes;
						a.EstimatedCost = projectDTO.EstimatedCost;
						a.ProjectManager = projectDTO.ProjectManager;
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

        public List<ProjectTaskColumnChartModel> GetProjectTaskColumnChart(Int64 EmployeeId, Int64 UserId)
		{
			var myOpenProjects = GetMyAssignedProject(EmployeeId, UserId).Where(x => x.Status == "Open").ToList();
			List<ProjectTaskColumnChartModel> columnChartModels = new List<ProjectTaskColumnChartModel>();
		
            for (int i = 0; i < myOpenProjects.Count; i++)
			{
                var tasks = _projectTaskService.ProjectTaskByProjectId(myOpenProjects[i].ProjectId).ToList();

                columnChartModels.Add(new ProjectTaskColumnChartModel
				{
					ProjectName = myOpenProjects[i].ProjectName,
					ProjectCode = myOpenProjects[i].ProjectCode,
					TotalTaskCount= tasks.Count,
					OpenTaskCount = tasks.Where(x=>x.TaskStatus == "Open").ToList().Count(),
					WorkingTaskCount = tasks.Where(x=>x.TaskStatus == "Working").ToList().Count(),
                    ReviewTaskCount = tasks.Where(x=>x.TaskStatus == "PendingReview").ToList().Count(),
					OverdueTaskCount = tasks.Where(x=>x.TaskStatus == "Overdue").ToList().Count(),
					CompletedTaskCount = tasks.Where(x=>x.TaskStatus == "Completed").ToList().Count(),
					CancelledTaskCount = tasks.Where(x=>x.TaskStatus == "Cancelled").ToList().Count()

                });
			}
			return columnChartModels;

        }
        public List<ProjectWiseTimesheetEffortAnalysys> GetProjectWiseTimesheetEffortAnalysys(Int64 EmployeeId, Int64 UserId)
		{
            List<ProjectWiseTimesheetEffortAnalysys> projectWiseTimesheetEffortAnalysys =  new List<ProjectWiseTimesheetEffortAnalysys>();
            var myOpenProjects = GetMyAssignedProject(EmployeeId, UserId).Where(x => x.Status == "Open").ToList();

            for (int i = 0; i < myOpenProjects.Count; i++)
            {
                var timesheet = _timeSheetService.GetNotRejectedTimesheetByProjectId(myOpenProjects[i].ProjectId).ToList();
                double totatlTimeSpent = 0.0;
                for (int j = 0; j < timesheet.Count; j++)
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

                    if (timesheet[j].DurationInHours.ToString().Split(".").Count() == 2)
                    {
                        hour1 = int.Parse(timesheet[j].DurationInHours.ToString().Split(".")[0]);


                        min1 = int.Parse(timesheet[j].DurationInHours.ToString().Split(".")[1]);
                    }
                    else
                    {
                        hour1 = int.Parse(timesheet[j].DurationInHours.ToString());

                    }





                    hour1 = hour1 + hour;
                    min1 = min1 + min;
                    TimeSpan hours = TimeSpan.FromMinutes(min1);
                    hour1 = hour1 + int.Parse(hours.ToString("hh"));
                    int min2 = int.Parse(hours.ToString("mm"));
                    string finalno = hour1.ToString() + "." + min2.ToString();
                    totatlTimeSpent = double.Parse(finalno);
                }
                projectWiseTimesheetEffortAnalysys.Add(new ProjectWiseTimesheetEffortAnalysys
				{
					ProjectName = myOpenProjects[i].ProjectName,
					ProjectCode = myOpenProjects[i].ProjectCode,
					PlannedEffortHours = (double)myOpenProjects[i].EffortHourRequired,
					EffotHourUsed = totatlTimeSpent

                }) ;
            }

            return projectWiseTimesheetEffortAnalysys;

        }


		private async void SendProjectAssignmentNotification(ProjectDTO projectDTO)
		{
            string baseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host;

            EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplateByName("ProjectAssignment");
            string emailTemp = emailTemplate.EmailTemplateDescription.Trim();
            CompanyDetails company = _companyDetailsService.GetCompanyDetails();
            LetterHead letter = _letterHeadService.GetLetter();
            EmailAccount emailA = _emailAccountService.GetDefaultEmail(emailTemplate.DefaultSendingAccount);
            StringBuilder stringBuilder = new StringBuilder(emailTemp);
			var pm = _employeeService.GetEmployeeById(Int64.Parse(projectDTO.ProjectManager.ToString()));
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
			if(projectDTO!= null)
			{
                stringBuilder = stringBuilder.Replace("{%ProjectName%}", projectDTO.ProjectName);

                stringBuilder = stringBuilder.Replace("{%projectid%}", projectDTO.ProjectCode);
                stringBuilder = stringBuilder.Replace("{%startdate%}",DateTime.Parse( projectDTO.StartDate.ToString()).ToString("dd-MMM-yyyy"));
                stringBuilder = stringBuilder.Replace("{%enddate%}", DateTime.Parse(projectDTO.EndDate.ToString()).ToString("dd-MMM-yyyy"));

				if (pm != null)
				{
                    stringBuilder = stringBuilder.Replace("{%projectmanagername%}",pm.FullName);
                }
                stringBuilder = stringBuilder.Replace("{%projectdescription%}", projectDTO.ProjectNotes);

            }
            string subject = emailTemplate.Subject;
            subject = subject.Replace("{%ProjectName%}", projectDTO.ProjectName);
			var employees = (from u in projectDTO.ProjectEmployees
							 join r in _Context.Employees on
							u.EmployeeId equals r.EmployeeId
                             select new { u.EmployeeId, r.CompanyEmail, r.FirstName }
                            ).ToList();
            for (int i =0;i< employees.Count;i++)
			{
			

                        if (emailA != null)
                        {
                            stringBuilder = stringBuilder.Replace("{%helloname%}", employees[i].FirstName);



                            await _emailService.SendEmailAsync(new MailRequest
                            {
                                SenderEmail = emailA.EmailAddress,
                                MailBoxName = emailA.EmailAccountName,
                                MailBoxEmail = emailA.AlternativeEmailAddress,
                                Host = emailA.EmailDomain.OutingServer,
                                Port = emailA.EmailDomain.OutgoingPort,
                                AuthEmail = emailA.EmailAddress,
                                AuthPassword = emailA.EmailPassword,
                                ToEmail = employees[i].CompanyEmail,
                                Subject = subject,
                                Body = stringBuilder.ToString()

                            });
                            stringBuilder = stringBuilder.Replace(employees[i].FirstName, "{%helloname%}");

                        }
                    
                
				
			}

        }

    }
}
