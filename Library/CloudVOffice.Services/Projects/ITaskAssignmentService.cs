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
    public interface ITaskAssignmentService
    {
        public MennsageEnum TaskAssignmentCreate(TaskAssignmentDTO taskAssignmentDTO);
        public List<TaskAssignment> GetTaskAssignments();
        public TaskAssignment GetTaskAssignmentByTaskAssignmentId(Int64 taskAssignmentId);
        public MennsageEnum TaskAssignmentUpdate(TaskAssignmentDTO taskAssignmentDTO);
        public MennsageEnum TaskAssignmentDelete(Int64 taskAssignmentId, Int64 DeletedBy);
    }
}
