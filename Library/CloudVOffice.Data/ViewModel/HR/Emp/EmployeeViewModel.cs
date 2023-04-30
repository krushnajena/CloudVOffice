using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.ViewModel.HR.Emp
{
	public class EmployeeViewModel : Employee
	{
		public string DepartmentName { get; set; }	
		public string DesgnationName { get; set; }	

	}
}
