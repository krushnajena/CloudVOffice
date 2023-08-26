using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
    public interface IWorkFromHomeRequestService
    {
        public MessageEnum WorkFromHomeRequestCreate(WorkFromHomeRequestDTO workFromHomeRequestDTO);
        public List<WorkFromHomeRequest> GetWorkFromHomeRequestList();
        public WorkFromHomeRequest GetWorkFromHomeRequestById(Int64 workFromHomeRequestId);
        public MessageEnum WorkFromHomeRequestUpdate(WorkFromHomeRequestDTO workFromHomeRequestDTO);
        public MessageEnum WorkFromHomeRequestDelete(Int64 workFromHomeRequestId, Int64 DeletedBy);
    }
}
