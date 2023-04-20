using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Emp
{
	public interface IEmployeeService
	{
		public  MennsageEnum CreateEmployee(EmployeeCreateDTO employeeCreateDTO);
		public List<Employee> GetEmployees();
		public Employee GetEmployeeByCode(string employeecode);
		public Employee GetEmployeeById(Int64 employeeid);
		public MennsageEnum UpdateEmployee(EmployeeCreateDTO employeeCreateDTO);
		public MennsageEnum DeleteEmployee(Int64 employeeid, Int64 DeletedBy);
		
	}
}
