using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
    public interface IShiftEmployeeService
    {
        public MessageEnum CreateShiftEmployee(ShiftEmployeeDTO shiftEmployeeDTO);
        public List<ShiftEmployee> GetShiftEmployeeList();
        public ShiftEmployee GetShiftEmployeeById(Int64 shiftEmployeeId);
        public MessageEnum ShiftEmployeeUpdate(ShiftEmployeeDTO shiftEmployeeDTO);
        public MessageEnum ShiftEmployeeDelete(Int64 shiftEmployeeId, Int64 DeletedBy);
    }
}
