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
	public interface IEmpolyeeService
	{
		public  Task<MennsageEnum> CreateEmployee(EmployeeCreateDTO employeeCreateDTO);
		public List<Employee> GetEmps();
		public Employee GetEmployeeByCode(string employeecode);
		public MennsageEnum UpdateEmployee(EmployeeCreateDTO employeeCreateDTO);
		public MennsageEnum DeleteEmployee(int employeeid, int DeletedBy);
		
	}
}
