using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
    public class TaskAssignmentService : ITaskAssignmentService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<TaskAssignment> _taskAssignmentRepo;
        public TaskAssignmentService(ApplicationDBContext Context, ISqlRepository<TaskAssignment> taskAssignmentRepo)
        {

            _Context = Context;
            _taskAssignmentRepo = taskAssignmentRepo;
        }
        public TaskAssignment GetTaskAssignmentByTaskAssignmentId(Int64 taskAssignmentId)
        {
            try
            {
                return _Context.TaskAssignments.Where(x => x.TaskAssignmentId == taskAssignmentId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<TaskAssignment> GetTaskAssignments()
        {
            try
            {
                return _Context.TaskAssignments.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum TaskAssignmentCreate(TaskAssignmentDTO taskAssignmentDTO)
        {
            var objCheck = _Context.TaskAssignments.SingleOrDefault(opt => opt.TaskAssignmentId == taskAssignmentDTO.TaskAssignmentId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    TaskAssignment taskAssignment = new TaskAssignment();
                    taskAssignment.TaskId = taskAssignmentDTO.TaskId;
                    taskAssignment.EmployeeId = taskAssignmentDTO.EmployeeId;
                    taskAssignment.AssignedBy = taskAssignmentDTO.AssignedBy;
                    taskAssignment.AssignedOn = taskAssignmentDTO.AssignedOn;
                    taskAssignment.CompliteBy = taskAssignmentDTO.CompliteBy;
                    taskAssignment.ActualCompliteOn = taskAssignmentDTO.ActualCompliteOn;
                    taskAssignment.DelayReason = taskAssignmentDTO.DelayReason;
                    taskAssignment.IsDelayApproved = taskAssignmentDTO.IsDelayApproved;
                    taskAssignment.DelayApprovedBy = taskAssignmentDTO.DelayApprovedBy;
                    taskAssignment.DelayApprovedOn = taskAssignmentDTO.DelayApprovedOn;
                    taskAssignment.CreatedBy = Int64.Parse(taskAssignmentDTO.CreatedBy.ToString());
                    var obj = _taskAssignmentRepo.Insert(taskAssignment);

                    return MennsageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MennsageEnum.Duplicate;
                }

                return MennsageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum TaskAssignmentDelete(Int64 taskAssignmentId, Int64 DeletedBy)
        {

            try
            {
                var a = _Context.TaskAssignments.Where(x => x.TaskAssignmentId == taskAssignmentId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MennsageEnum.Deleted;
                }
                else
                    return MennsageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum TaskAssignmentUpdate(TaskAssignmentDTO taskAssignmentDTO)
        {

            try
            {
                var taskAssignment = _Context.TaskAssignments.Where(x => x.TaskAssignmentId != taskAssignmentDTO.TaskAssignmentId && x.Deleted == false).FirstOrDefault();
                if (taskAssignment == null)
                {
                    var a = _Context.TaskAssignments.Where(x => x.TaskAssignmentId == taskAssignmentDTO.TaskAssignmentId).FirstOrDefault();
                    if (a != null)
                    {
                        a.TaskId = taskAssignmentDTO.TaskId;
                        a.EmployeeId = taskAssignmentDTO.EmployeeId;
                        a.AssignedBy = taskAssignmentDTO.AssignedBy;
                        a.AssignedOn = taskAssignmentDTO.AssignedOn;
                        a.CompliteBy = taskAssignmentDTO.CompliteBy;
                        a.ActualCompliteOn = taskAssignmentDTO.ActualCompliteOn;
                        a.DelayReason = taskAssignmentDTO.DelayReason;
                        a.IsDelayApproved = taskAssignmentDTO.IsDelayApproved;
                        a.DelayApprovedBy = taskAssignmentDTO.DelayApprovedBy;
                        a.DelayApprovedOn = taskAssignmentDTO.DelayApprovedOn;
                        a.UpdatedBy = taskAssignmentDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MennsageEnum.Updated;
                    }
                    else
                        return MennsageEnum.Invalid;
                }
                else
                {
                    return MennsageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
