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
	public interface IEmployeeAttendanceService
	{
		
		
			public MessageEnum CreateEmployeeAttendance(EmployeeAttendanceDTO employeeAttendanceDTO);
			public List<EmployeeAttendance> GetEmployeeAttendanceList();
			public EmployeeAttendance GetEmployeeAttendanceById(Int64 EmployeeAttendanceId);
			public MessageEnum EmployeeAttendanceUpdate(EmployeeAttendanceDTO employeeAttendanceDTO);
			public MessageEnum EmployeeAttendanceDelete(Int64 EmployeeAttendanceId, Int64 DeletedBy);
		    public MessageEnum EmployeeAttendanceUpdate(Int64 EmployeeId, DateTime AttendanceDate); 

    }
}

