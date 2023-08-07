	using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.EmailTemplates;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Company;
using CloudVOffice.Services.Comunication;
using CloudVOffice.Services.Email;
using CloudVOffice.Services.EmailTemplates;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
	public class ProjectTaskService : IProjectTaskService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ProjectTask> _projectTaskRepo;


        private readonly IEmployeeService _employeeService;
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICompanyDetailsService _companyDetailsService;
        private readonly ILetterHeadService _letterHeadService;
        private readonly IEmailAccountService _emailAccountService;
        private readonly IEmailService _emailService;
		private readonly IConfiguration _configuration;

		public ProjectTaskService(ApplicationDBContext Context, ISqlRepository<ProjectTask> projectTaskRepo,


              IEmailTemplateService emailTemplateService,
             IHttpContextAccessor httpContextAccessor,
             ICompanyDetailsService companyDetailsService,
             ILetterHeadService letterHeadService,
             IEmailAccountService emailAccountService,
        IEmailService emailService,
        IEmployeeService employeeService,
			 IConfiguration configuration
			)
		{

			_Context = Context;
			_projectTaskRepo = projectTaskRepo;

            _emailTemplateService = emailTemplateService;
            _httpContextAccessor = httpContextAccessor;
            _letterHeadService = letterHeadService;
            _companyDetailsService = companyDetailsService;
            _emailAccountService = emailAccountService;
            _emailService = emailService;
            _employeeService = employeeService;
			_configuration = configuration;
		}
		public MessageEnum ProjectTaskCreate(ProjectTaskDTO projectTaskDTO)
		{
			var objCheck = _Context.ProjectTasks.SingleOrDefault(opt => opt.ProjectTaskId == projectTaskDTO.ProjectTaskId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					ProjectTask projectTask = new ProjectTask();
					projectTask.ProjectId = projectTaskDTO.ProjectId;
					projectTask.EmployeeId = projectTaskDTO.EmployeeId;
					projectTask.AssignedBy = projectTaskDTO.AssignedBy;
					projectTask.AssignedOn = System.DateTime.Now;

					projectTask.TaskName = projectTaskDTO.TaskName;
					projectTask.Priority = projectTaskDTO.Priority;
					projectTask.ParentTaskId = projectTaskDTO.ParentTaskId;
					projectTask.IsGroup = projectTaskDTO.IsGroup;
					projectTask.ExpectedStartDate = projectTaskDTO.ExpectedStartDate;
					projectTask.ExpectedEndDate = projectTaskDTO.ExpectedEndDate;
					projectTask.ExpectedTimeInHours = projectTaskDTO.ExpectedTimeInHours;
					projectTask.Progress = projectTaskDTO.Progress;
					projectTask.TaskDescription = projectTaskDTO.TaskDescription;
					projectTask.TaskStatus = projectTaskDTO.TaskStatus;
					projectTask.CreatedBy = projectTaskDTO.CreatedBy;
					var obj = _projectTaskRepo.Insert(projectTask);

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
		public ProjectTask GetProjectTaskByProjectTaskId(Int64 projectTaskId)
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public ProjectTask GetProjectTaskByTaskName(string taskName)
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.TaskName == taskName && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> GetProjectTasks()
		{
			try
			{
				return _Context.ProjectTasks.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		

		public MessageEnum ProjectTaskDelete(Int64 projectTaskId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskId).FirstOrDefault();
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

		public MessageEnum ProjectTaskUpdate(ProjectTaskDTO projectTaskDTO)
		{
			try
			{
				var projectTask = _Context.ProjectTasks.Where(x => x.ProjectTaskId != projectTaskDTO.ProjectTaskId && x.TaskName == projectTaskDTO.TaskName && x.Deleted == false).FirstOrDefault();
				if (projectTask == null)
				{
					var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskDTO.ProjectTaskId).FirstOrDefault();
					if (a != null)
					{
						a.ProjectId = projectTaskDTO.ProjectId;
						a.TaskName = projectTaskDTO.TaskName;
						a.Priority = projectTaskDTO.Priority;
						a.ParentTaskId = projectTaskDTO.ParentTaskId;
						a.IsGroup = projectTaskDTO.IsGroup;
						a.ExpectedStartDate = projectTaskDTO.ExpectedStartDate;
						a.ExpectedEndDate = projectTaskDTO.ExpectedEndDate;
						a.ExpectedTimeInHours = projectTaskDTO.ExpectedTimeInHours;
						a.Progress = projectTaskDTO.Progress;
						a.TaskDescription = projectTaskDTO.TaskDescription;
						//a.ComplitedBy = projectTaskDTO.ComplitedBy;
						//a.ComplitedOn = projectTaskDTO.ComplitedOn;
						//a.TotalHoursByTimeSheet = projectTaskDTO.TotalHoursByTimeSheet;
						//a.TotalBillableHourByTimeSheet = projectTaskDTO.TotalBillableHourByTimeSheet;
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

        public List<ProjectTask> ProjectTaskByProjectId(int ProjectId)
        {
            try
            {
                return _Context.ProjectTasks
					
					.Include(a=>a.Project)
                   
					.Include(f=>f.AssignedTo)
                    .Where(x => x.ProjectId == ProjectId && x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

		public List<ProjectTask> GroupProjectTaskByProjectId(int ProjectId)
		{
			try
			{
				return _Context.ProjectTasks

					.Where(x => x.ProjectId == ProjectId && x.Deleted == false && x.IsGroup == true).ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> NotCanceledTasksByProjectId(int projectId)
		{
			try
			{
				return _Context.ProjectTasks

					.Include(a => a.Project)

					.Include(f => f.Employee)
					.Where(x => x.ProjectId == projectId && x.Deleted == false && x.TaskStatus !="Canceled").ToList();

			}
			catch
			{
				throw;
			}
		}

		public List<ProjectTask> GetTaskComplitedByOthersReport(Int64? Userid, Int64? EmployeeId)
		{
			try
			{
				
				return  _Context.ProjectTasks
						.Include(a=>a.Project)
						.ThenInclude(a=>a.ProjectEmployees)
						.Include(a => a.Project)
						.ThenInclude(x => x.ProjectUsers)
						.Include(a=>a.Employee)
						.Include(a=>a.AssignedTo)
					

					
					.Where(x => x.Deleted == false &&  (
					x.Project.ProjectManager == EmployeeId
					|| x.Project.ProjectEmployees.Any(d=>d.EmployeeId == EmployeeId && d.Deleted == false) 
					|| x.Project.ProjectUsers.Any(d=>d.UserId == Userid && d.Deleted == false))
					&& x.EmployeeId != x.ComplitedBy
					).ToList();

			}
			catch
			{
				throw;
			}

		}

		public List<ProjectTask> GetTaskDelayReport(Int64? Userid, Int64? EmployeeId)
		{
			try
			{
			      return _Context.ProjectTasks
						.Include(a => a.Project)
						.ThenInclude(a => a.ProjectEmployees)
						.Include(a => a.Project)
						.ThenInclude(x => x.ProjectUsers)
						.Include(a => a.Employee)
						.Include(a => a.AssignedTo)



					.Where(x => x.Deleted == false && (
					x.Project.ProjectManager == EmployeeId
					|| x.Project.ProjectEmployees.Any(d => d.EmployeeId == EmployeeId && d.Deleted == false)
					|| x.Project.ProjectUsers.Any(d => d.UserId == Userid && d.Deleted == false)) && x.ExpectedEndDate < x.ComplitedOn).ToList();


			}
			catch
			{
				throw;
			}
		}

        public MessageEnum ProjectTaskStatusUpdate(ProjectTaskDTO projectTaskDTO)
        {
			try
			{
				var projectTask = _Context.ProjectTasks.Where(x=>x.ProjectTaskId== projectTaskDTO.ProjectTaskId).FirstOrDefault();
				projectTask.TaskStatus  = projectTaskDTO.TaskStatus;
				projectTask.UpdatedBy = projectTaskDTO.CreatedBy;
				projectTask.UpdatedDate = System.DateTime.Now;	
				if(projectTask.TaskStatus == "Open")
				{
					projectTask.Progress = 0;

                }
				else if (projectTask.TaskStatus == "Working")
                {
                    projectTask.Progress = 30;

                }
                else if (projectTask.TaskStatus == "PendingReview")
                {
                    projectTask.Progress = 80;

                }
                else if (projectTask.TaskStatus == "Completed")
                {
                    projectTask.Progress = 100;
                    projectTask.ComplitedBy = projectTaskDTO.EmployeeId;
                    projectTask.ComplitedOn = DateTime.Now;

                }
                _Context.SaveChanges();
				return MessageEnum.Success;

            }
			catch
			{
				throw;
			}
        }
      

       

		public List<ProjectTask> GetMYTaskComplitedByOthersReport( Int64? EmployeeId)

		{
            try
            {

                return _Context.ProjectTasks
                        .Include(a => a.Project)
                        .ThenInclude(a => a.ProjectEmployees)
                        .Include(a => a.Project)
                        .ThenInclude(x => x.ProjectUsers)
                        .Include(a => a.Employee)
                        .Include(a => a.AssignedTo)



                    .Where(x => x.Deleted == false 
				
                   
                    && x.EmployeeId != x.ComplitedBy && (x.EmployeeId == EmployeeId || x.ComplitedBy == EmployeeId)
                    ).ToList();

            }
            catch
            {
                throw;
            }

        }


        public List<ProjectTask> GetTasksForDelayValidation(Int64? Userid, Int64? EmployeeId)
		{
            try
            {
                return _Context.ProjectTasks
						.Include(e=>e.AssignedTo)
                      .Include(a => a.Project)
                      .ThenInclude(b => b.ProjectEmployees)
                      .Include(c => c.Project)
                      .ThenInclude(x => x.ProjectUsers)
                      .Include(a => a.Employee)
                   



                  .Where(x => x.Deleted == false 
				  && 
                  x.Project.ProjectManager == EmployeeId 
					 && x.ComplitedOn> x.ExpectedEndDate && x.IsDelayApproved == 0   
				  ).ToList();


            }
            catch
            {
                throw;
            }


        }

		public List<ProjectTask> GetMyTaskDelayList(Int64? EmployeeId)
		{

			try
			{
				return _Context.ProjectTasks
					  .Include(a => a.Project)
					  .ThenInclude(a => a.ProjectEmployees)
					  .Include(a => a.Employee)
					  .Include(a => a.AssignedTo)



				  .Where(x => x.Deleted == false && 
				   x.EmployeeId == EmployeeId ).ToList();


			}
			catch
			{
				throw;
			}
		}

        public MessageEnum TaskDelayReasonUpdate(ProjectTaskDelayReasonUpdateDTO projectTaskDelayReasonUpdateDTO)
        {
            try
            {
              
                    var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == projectTaskDelayReasonUpdateDTO.ProjectTaskId).FirstOrDefault();
                    if (a != null)
                    {
                      
                        a.DelayReason = projectTaskDelayReasonUpdateDTO.DelayReason;
						a.IsDelayApproved = 0;
					
						a.UpdatedBy = projectTaskDelayReasonUpdateDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum TaskComplitedByOthersReasonUpdate(TaskComplitedByOthersReasonUpdateDTO taskComplitedByOthersReasonUpdateDTO)
        {
			try
			{

                var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == taskComplitedByOthersReasonUpdateDTO.ProjectTaskId).FirstOrDefault();
                if (a != null)
                {
					if(taskComplitedByOthersReasonUpdateDTO.EmployeeId == a.EmployeeId)
					{
                        a.TaskComplitedByOthersReasonByAssign = taskComplitedByOthersReasonUpdateDTO.Reason;
                    }
					else
					{
                        a.TaskComplitedByOthersReasonByComplitedBy = taskComplitedByOthersReasonUpdateDTO.Reason;
                    }
                 
                    a.UpdatedBy = taskComplitedByOthersReasonUpdateDTO.CreatedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Updated;
                }
                else
                    return MessageEnum.Invalid;

            }
			catch
			{
				throw;
			}
        }

		public List<ProjectTask> GetTaskList(Int64? EmployeeId)
		{
			try
			{

				return _Context.ProjectTasks
					  .Include(a=> a.Project)
					  .ThenInclude(a=> a.ProjectEmployees)
					  .Include(a=> a.Employee)
					   .Where(x => x.Deleted == false &&
				   x.EmployeeId == EmployeeId ).ToList();



			}
			catch
			{
				throw;
			}
		}
        public MessageEnum TaskApproval(TaskApprovalDTO taskApprovalDTO)
		{
            try
            {
                var task = _Context.ProjectTasks.Where(x => x.ProjectTaskId == taskApprovalDTO.TaskId && x.Deleted == false).FirstOrDefault();
                if (task != null)
                {
                    task.IsDelayApproved = taskApprovalDTO.IsDelayApproved;
                    task.DelayApprovalReason = taskApprovalDTO.DelayApprovalReason;
                    task.DelayApprovedOn = DateTime.Now;
                    task.DelayApprovedBy= taskApprovalDTO.ApprovedBy;
                    task.UpdatedBy = taskApprovalDTO.UpdatedBy;
                    task.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();

                    return taskApprovalDTO.IsDelayApproved == 1 ? MessageEnum.Approved : MessageEnum.Rejected;
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
        public ProjectTask UpdateTimeSheetHour(Int64 TaskId, Double? Hour)
		{
			try
			{
				var a = _Context.ProjectTasks.Where(x => x.ProjectTaskId == TaskId).FirstOrDefault();
				if(a != null)
				{
					if (a.TotalHoursByTimeSheet != null)
					{




						int hour = 0;
						int min = 0;
						if (a.TotalHoursByTimeSheet.ToString().Split(".").Count() == 2)
						{
							hour = int.Parse(a.TotalHoursByTimeSheet.ToString().Split(".")[0]);
							min = int.Parse(a.TotalHoursByTimeSheet.ToString().Split(".")[1]);
						}
						else
						{
							hour = int.Parse(a.TotalHoursByTimeSheet.ToString());
						}

						int hour1 = 0;

						int min1 = 0;
						if (Hour.ToString().Split(".").Count() == 2)
						{
							 hour1 = int.Parse(Hour.ToString().Split(".")[0]);
							min1 = int.Parse(Hour.ToString().Split(".")[1]);
						}
						else
						{
							 hour1 = int.Parse(Hour.ToString());
						}

						hour1 = hour1+hour;
						min1 = min1+min;
                        TimeSpan hours = TimeSpan.FromMinutes(min1);
						hour1 = hour1+ int.Parse(hours.ToString("hh"));
						int min2 = int.Parse(hours.ToString("mm"));
						string finalno = hour1.ToString() + "." + min2.ToString();
						a.TotalHoursByTimeSheet = double.Parse(finalno); 

                    }
					else
					{
                        a.TotalHoursByTimeSheet = Hour;
                    }
					_Context.SaveChanges();
				}
				return a;
			}
			catch
			{
				throw;
			}
		}



        public async Task TodayDueProjectTasksSendNotification()
		{
			try
			{
				var list =  _Context.ProjectTasks
                        .Include(a => a.AssignedTo)
                    .Include(a => a.Project)
                      .ThenInclude(a => a.ProjectEmployees)
                      .Include(a => a.Employee)
                       .Where(x => x.Deleted == false &&
                   x.ExpectedEndDate == DateTime.Today &&  x.TaskStatus != "Completed "  && x.TaskStatus != "Cancelled").ToList();

				for(int i=0;i<list.Count;i++)
				{
					await SendTaskNotification("TaskDueTodayReminder", list[i]);

                }
				

            }
			catch
			{
				throw;
			}
		}

        public async Task MarkTaskOverDueAndSendNotification()
		{
            try
            {
                var list = _Context.ProjectTasks
                     .Include(a => a.AssignedTo)
					 .Include(a => a.Project)
                      .ThenInclude(a => a.ProjectEmployees)
                      .Include(a => a.Employee)
                       .Where(x => x.Deleted == false &&
                   x.ExpectedEndDate == DateTime.Today.AddDays(-1) && x.TaskStatus != "Completed " && x.TaskStatus != "Cancelled" && x.TaskStatus!= "Overdue").ToList();

                for (int i = 0; i < list.Count; i++)
                {
					
                    var task = _Context.ProjectTasks.Where(x => x.ProjectTaskId == list[i].ProjectTaskId).FirstOrDefault();
                    task.TaskStatus = "Overdue";
					task.UpdatedBy = 1;
					task.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
                   await SendTaskNotification("TaskOverdue", list[i]);

                }


            }
            catch
            {
                throw;
            }
        }


        private async Task SendTaskNotification(string templateName,ProjectTask projectTask)
		{
			string baseUrl = _configuration["Application:appurl"];


			EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplateByName(templateName);
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
            stringBuilder = stringBuilder.Replace("{%Name%}", projectTask.AssignedTo.FirstName);
            stringBuilder = stringBuilder.Replace("{%TaskName%}", projectTask.TaskName);

            stringBuilder = stringBuilder.Replace("{%TaskId%}", projectTask.ProjectTaskId.ToString());

            stringBuilder = stringBuilder.Replace("{%DueDate%}", DateTime.Parse(projectTask.ExpectedEndDate.ToString()).ToString("dd-MMM-yyyy"));
            stringBuilder = stringBuilder.Replace("{%ProjectName%}", projectTask.Project.ProjectName);
            stringBuilder = stringBuilder.Replace("{%ProjectId%}", projectTask.Project.ProjectCode);

            stringBuilder = stringBuilder.Replace("{%CurrentDate%}",DateTime.Today.ToString("dd-MMM-yyyy"));

            if (emailA != null)
            {

                string subject = emailTemplate.Subject;
                subject = subject.Replace("{%Taskname%}", projectTask.TaskName);


                await _emailService.SendEmailAsync(new MailRequest
                {
                    SenderEmail = emailA.EmailAddress,
                    MailBoxName = emailA.EmailAccountName,
                    MailBoxEmail = emailA.AlternativeEmailAddress,
                    Host = emailA.EmailDomain.OutingServer,
                    Port = emailA.EmailDomain.OutgoingPort,
                    AuthEmail = emailA.EmailAddress,
                    AuthPassword = emailA.EmailPassword,
                    ToEmail = projectTask.AssignedTo.CompanyEmail,
                    Subject = subject,
                    Body = stringBuilder.ToString()

                });
              

            }


        }









    }
    
}
	